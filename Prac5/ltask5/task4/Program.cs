using System;

namespace Pract5_Task4
{
    class Program
    {
        static int Factorial(int n)
        {
            int res = 1;
            for (int i = 2; i <= n; i++)
                res *= i;
            return res;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 1;
            for (int i = 1; i <= n; i++)
                sum += 1.0 / Factorial(i);
            Console.WriteLine(sum);
        }
    }
}