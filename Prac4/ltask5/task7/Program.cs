using System;

namespace Pract5_Task7
{
    class Program
    {
        static double AlternatingSum(int n)
        {
            double sum = 0;
            int sign = 1;
            for (int i = 1; i <= n; i++)
            {
                sum += sign * (1.0 / i);
                sign = -sign;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(AlternatingSum(n));
        }
    }
}