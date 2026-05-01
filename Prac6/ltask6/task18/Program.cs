using System;
using System.Linq;

namespace Pract6_Task18
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
            int[] unique = arr.Distinct().ToArray();
            foreach (int x in unique)
                Console.Write(x + " ");
        }
    }
}