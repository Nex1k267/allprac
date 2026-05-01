using System;

namespace Pract6_Task5_1
{
    class Program
    {
        static int SumEvenIndices(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i += 2)
                sum += array[i];
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Размер массива: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                arr[i] = rnd.Next(-100, 100);
            Console.WriteLine(SumEvenIndices(arr));
        }
    }
}