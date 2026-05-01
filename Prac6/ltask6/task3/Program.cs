using System;

namespace Pract6_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < arr.Length; i += 2)
                if (arr[i] < 0)
                    sum += arr[i];
            Console.WriteLine(sum);
        }
    }
}