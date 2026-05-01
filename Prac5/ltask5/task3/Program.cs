using System;

namespace Pract5_Task3
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

        static int SumFactorials(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
                sum += Factorial(i);
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(SumFactorials(n));
        }
    }
}