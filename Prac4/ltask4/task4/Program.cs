using System;

namespace Pract4_Task1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            while (N > 0)
            {
                int digit = N % 10;
                Console.WriteLine(digit);
                N = N / 10;
            }
        }
    }
}