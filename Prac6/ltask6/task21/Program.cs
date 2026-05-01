using System;

namespace Pract6_Task21
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
            Console.Write("m: ");
            int m = int.Parse(Console.ReadLine());
            m %= n;
            int[] shifted = new int[n];
            for (int i = 0; i < n; i++)
                shifted[(i + m) % n] = arr[i];
            foreach (int x in shifted)
                Console.Write(x + " ");
        }
    }
}