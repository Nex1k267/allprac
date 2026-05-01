using System;

namespace Pract6_Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());
            int[] newArr = new int[n - 4];
            for (int i = 4; i < n; i++)
                newArr[i - 4] = arr[i];
            foreach (int x in newArr)
                Console.Write(x + " ");
        }
    }
}