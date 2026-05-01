using System;

namespace Pract4_Task3_10_a
{
    class Program
    {
        static void Main(string[] args)
        {
            double probeg = 10;
            for (int i = 2; i <= 10; i++)
            {
                probeg += probeg * 0.1;
                Console.WriteLine(i + " день: " + probeg);
            }
        }
    }
}