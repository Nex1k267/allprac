using System;

namespace Pract6_Task8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            double[] arr = new double[n];
            double fact = 1;
            for (int i = 0; i < n; i++)
            {
                fact *= (i + 1);
                arr[i] = 1.0 / fact;
            }
            double sum = 0;
            foreach (double x in arr)
                sum += x;
            Console.WriteLine(1 + sum);
        }
    }
}