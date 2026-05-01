using System;

namespace Pract4_Task3_11_c
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = 100;
            double yield = 20;
            double total = 0;
            for (int year = 1; year <= 6; year++)
            {
                total += area * yield;
                area *= 1.05;
                yield *= 1.02;
            }
            Console.WriteLine(total);
        }
    }
}