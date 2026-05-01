using System;

namespace Pract4_Task3_10_b
{
    class Program
    {
        static void Main(string[] args)
        {
            double probeg = 10;
            double sum = 10;
            for (int i = 2; i <= 7; i++)
            {
                probeg += probeg * 0.1;
                sum += probeg;
            }
            Console.WriteLine(sum);
        }
    }
}