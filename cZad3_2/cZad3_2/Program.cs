using System;

namespace cZad3_2
{
    class Program
    {
        static double f(double x)
        {
            if (x == 1 || x == -1)
            {
                return 1;
            }
            else if (x >= 0 && x != 1)
            {
                return -1 / (1 - x);
            }
            else
            {
                return 1 / (1 + x);
            }
        }
        static void f(double x, out double y)
        {
            if (x == 1 || x == -1)
            {
                y = 1;
            }
            else if (x >= 0 && x != 1)
            {
                y = -1 / (1 - x);
            }
            else
            {
                y = 1 / (1 + x);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                string zad2 = String.Empty;
                string zad3 = String.Empty;
                Console.Write("Введите a:");
                double a = Double.Parse(Console.ReadLine());
                Console.Write("Введите b:");
                double b = Double.Parse(Console.ReadLine());
                Console.Write("Введите h:");
                double h = Double.Parse(Console.ReadLine());
                Console.WriteLine("Задание 2");
                for (double x = a; x<=b; x+=h)
                {
                    zad2 += f(x).ToString() + " ";
                }
                Console.WriteLine(zad2);
                Console.WriteLine("Задание 3");
                for (double x = a; x <= b; x += h)
                {
                    double y;
                    f(x, out y);
                    zad3 += y + " ";
                }
                Console.WriteLine(zad3);
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Вы ввели что-то не то!");
            }
        }
    }
}
