using System;

namespace cZad4_1
{
    class prac

    {
        public prac(int a, int b)
        {           
            Console.WriteLine(nod(Math.Abs(a), Math.Abs(b)));           
        }
        int nod(int a, int b)
        {
            if (a == b) 
            { 
                return a; 
            }
            else if (a > b)
            {
                return nod(a - b, b);
            }
            else
            {
                return nod(a, b - a);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Введите b: ");
                int b = int.Parse(Console.ReadLine());
                prac p = new prac(a, b);
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Нужно вводить целые числа!");
            }
        }
    }
}
