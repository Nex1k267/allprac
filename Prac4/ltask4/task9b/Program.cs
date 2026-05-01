using System;

namespace Pract4_Task3_9_b
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            for (int n = 1; n <= 100; n++)
                total += 1.0 / n;
            Console.WriteLine(total);
        }
    }
}