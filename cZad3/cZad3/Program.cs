using System;

namespace cZad3
{
    class Program
    {
        static double f(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }
        static string Result(double ab, double ac, double cd)
        {
            string str = (ab + ac + cd + f(f(ab, ac), cd)).ToString();
            return str;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите AB: ");
                double AB = Double.Parse(Console.ReadLine());
                Console.Write("Введите AC: ");
                double AC = Double.Parse(Console.ReadLine());
                Console.Write("Введите DC: ");
                double DC = Double.Parse(Console.ReadLine());
                Console.WriteLine("Результат: {0}", Result(AB, AC, DC));
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Вы ввели что-то не то!");
            }
        }
    }
}   
