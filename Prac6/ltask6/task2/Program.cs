using System;

namespace Pract6_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[8];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = double.Parse(Console.ReadLine());
            double sum = 0;
            int count = 0;
            foreach (double x in arr)
                if (x > 0) { sum += x; count++; }
            Console.WriteLine(count > 0 ? sum / count : 0);
        }
    }
}