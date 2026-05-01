using System;

namespace Pract6_Task13
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
            int[] squares = new int[n];
            for (int i = 0; i < n; i++)
                squares[i] = arr[i] * arr[i];
            foreach (int x in squares)
                Console.Write(x + " ");
        }
    }
}