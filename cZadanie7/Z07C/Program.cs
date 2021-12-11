using System.Text;
using System;

namespace Z071Console
{
    class practica
    {
        StringBuilder sb = new StringBuilder();
        char ch;
        bool flag = false;
        int bufI;
        public practica()
        {
            Main();
        }
        void Main()
        {
            Console.Write("Введите строку: ");
            sb.Append(Console.ReadLine());
            while(true)
            {
                Console.Write("Найти первое и последнее вхождение символа: ");
                if (char.TryParse(Console.ReadLine(), out ch))
                {
                    for(int i = 0; i < sb.Length; i++)
                    {                        
                        if(sb[i] == ch)
                        {
                            bufI = i + 1;
                            if(!flag)
                            {
                                Console.WriteLine($"Первое вхождение в {i + 1}");
                                flag = true;
                            }
                        }
                    }
                    Console.WriteLine($"Последнее вхождение в {bufI}");
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели не символ");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            practica prac = new practica();    
        }
    }
}
