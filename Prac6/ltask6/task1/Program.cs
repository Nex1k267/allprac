using System;

namespace Pract6_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = M;
            foreach (int x in arr)
                Console.Write(x + " ");
        }
    }
}