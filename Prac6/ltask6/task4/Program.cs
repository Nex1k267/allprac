using System;

namespace Pract6_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[17];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = int.Parse(Console.ReadLine());
            double sum = 0;
            int count = 0;
            for (int i = 1; i < arr.Length; i += 2)
                if (arr[i] > 0) { sum += arr[i]; count++; }
            Console.WriteLine(count > 0 ? sum / count : 0);
        }
    }
}