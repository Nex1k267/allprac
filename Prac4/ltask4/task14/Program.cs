using System;

namespace Pract4_Task3_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long fact = 1;
            long sum = 0;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                sum += fact;
            }
            Console.WriteLine(sum);
        }
    }
}