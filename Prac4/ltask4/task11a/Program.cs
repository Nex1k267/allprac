using System;

namespace Pract4_Task3_11_a
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = 100;
            double yield = 20;
            for (int year = 2; year <= 8; year++)
            {
                area *= 1.05;
                yield *= 1.02;
                Console.WriteLine(year + " год: " + (area * yield));
            }
        }
    }
}