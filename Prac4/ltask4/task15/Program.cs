using System;

namespace Pract4_Task3_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 1;
            double fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                sum += 1.0 / fact;
            }
            Console.WriteLine(sum);
        }
    }
}