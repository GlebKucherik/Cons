using System;

namespace cZad4_2
{
    class prac
    {
        public prac(int k)
        {
            rec(k, 0);
        }
        void str(int i, string c)
        {
            int j = 0;
            while (j < i)
            {
                j++;
                Console.Write(c);
            }
        }
        void rec(int n, int i)
        {
            if (n >= 0)
            {
                str(i, "*");
                str(n, " ");
                str(i, "*");
                Console.WriteLine();
                rec(n - 2, i + 1);
                str(i, "*");
                str(n, " ");
                str(i, "*");
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите n: ");
                int n = int.Parse(Console.ReadLine());
                if (n%2!=0)
                {
                    throw new Exception("Число должно быть четное!");
                }
                prac p = new prac(n);
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Вы должны ввести целое число!");
            }
            catch(Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
}
