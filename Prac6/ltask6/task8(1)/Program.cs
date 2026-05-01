using System;

namespace Pract6_Task8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            double[] arr = new double[n];
            double xi = x;
            for (int i = 0; i < n; i++)
            {
                arr[i] = xi / (i + 1);
                xi *= x;
            }
            double sum = 0;
            foreach (double v in arr)
                sum += v;
            Console.WriteLine(sum);
        }
    }
}