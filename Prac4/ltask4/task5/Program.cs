using System;

namespace Pract4_Task3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            int sign = 1;
            for (int i = 1; i <= n; i++)
            {
                sum += sign * (1.0 / i);
                sign = -sign;
            }
            Console.WriteLine(sum);
        }
    }
}