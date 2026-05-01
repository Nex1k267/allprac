using System;
using System.Collections.Generic;

namespace Pract6_Task17
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
            foreach (int x in arr)
            {
                if (x < 20)
                    list.Add(x);
                else
                    break;
            }
            int[] newArr = list.ToArray();
            foreach (int x in newArr)
                Console.Write(x + " ");
        }
    }
}