using System;
using System.Linq;

namespace Pract6_Task12
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
            int[] filtered = arr.Where(x => x % 2 == 0).ToArray();
            foreach (int x in filtered)
                Console.Write(x + " ");
        }
    }
}