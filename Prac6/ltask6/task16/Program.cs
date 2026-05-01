using System;
using System.Collections.Generic;

namespace Pract6_Task16
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
            List<int> list = new List<int>();
            bool skipping = true;
            foreach (int x in arr)
            {
                if (skipping && x < 20)
                    continue;
                skipping = false;
                list.Add(x);
            }
            int[] newArr = list.ToArray();
            foreach (int x in newArr)
                Console.Write(x + " ");
        }
    }
}