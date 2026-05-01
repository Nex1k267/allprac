using System;

namespace Pract6_Task9
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
            bool allEven = true;
            foreach (int x in arr)
                if (x % 2 != 0)
                {
                    allEven = false;
                    break;
                }
            Console.WriteLine(allEven);
        }
    }
}