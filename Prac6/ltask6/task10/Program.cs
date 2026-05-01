using System;

namespace Pract6_Task10
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
            bool hasNegative = false;
            foreach (int x in arr)
                if (x < 0)
                {
                    hasNegative = true;
                    break;
                }
            Console.WriteLine(hasNegative);
        }
    }
}