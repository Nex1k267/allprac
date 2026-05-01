using System;

namespace Pract6_Task8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            double[] arr = new double[n];
            int sign = 1;
            for (int i = 0; i < n; i++)
            {
                arr[i] = sign * (1.0 / (i + 1));
                sign = -sign;
            }
            double sum = 0;
            foreach (double x in arr)
                sum += x;
            Console.WriteLine(sum);
        }
    }
}