using System;

namespace Pract6_Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            int[] fib = new int[n];
            if (n >= 1) fib[0] = 0;
            if (n >= 2) fib[1] = 1;
            for (int i = 2; i < n; i++)
                fib[i] = fib[i - 1] + fib[i - 2];
            foreach (int x in fib)
                Console.Write(x + " ");
        }
    }
}