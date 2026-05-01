using System;

namespace Pract5_Task8
{
    class Program
    {
        static double SeriesSum(double x)
        {
            double sum = 0;
            double xi = x;
            for (int i = 1; i <= 11; i += 2)
            {
                sum += xi / i;
                xi *= x * x;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine(SeriesSum(x));
        }
    }
}