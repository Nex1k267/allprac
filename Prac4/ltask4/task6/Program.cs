using System;

namespace Pract4_Task3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double sum = 0;
            double xi = x;
            for (int i = 1; i <= 11; i += 2)
            {
                sum += xi / i;
                xi *= x * x;
            }
            Console.WriteLine(sum);
        }
    }
}