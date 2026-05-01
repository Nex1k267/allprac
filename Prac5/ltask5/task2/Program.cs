using System;

namespace Pract5_Task2
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
            Console.WriteLine(Factorial(n));
        }
    }
}