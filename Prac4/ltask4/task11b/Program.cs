using System;

namespace Pract4_Task3_11_b
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = 100;
            for (int year = 4; year <= 7; year++)
            {
                area *= 1.05;
                Console.WriteLine(year + " год: " + area);
            }
        }
    }
}