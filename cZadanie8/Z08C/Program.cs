using System;
using System.Text;
using System.Text.RegularExpressions;
namespace Z08C
{
    class prac
    {
        public prac()
        {
            Main();
        }
        StringBuilder sb = new StringBuilder();
        string[] words;
        void Main()
        {
            Regex r = new Regex(@"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
            Console.Write("Введите строку: ");
            sb.Append(Console.ReadLine());
            words = sb.ToString().Split(' ');
            Console.WriteLine("Все IP");
            for (int i = 0; i < words.Length; i++)
            {
                if(r.IsMatch(words[i]))
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            prac p = new prac();
        }
    }
}
