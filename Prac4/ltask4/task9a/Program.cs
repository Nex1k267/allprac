using System;

namespace Pract4_Task3_9_a
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = 1;
            double sign = -1;
            double pos = 1;
            for (int n = 2; n <= 100; n++)
            {
                pos += sign * (1.0 / n);
                sign = -sign;
            }
            Console.WriteLine(pos);
        }
    }
}