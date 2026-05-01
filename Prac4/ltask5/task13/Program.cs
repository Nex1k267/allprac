using System;

namespace Pract5_Task13
{
    class Program
    {
        static void PrintFibonacciUpTo(int M)
        {
            int a = 0, b = 1;
            Console.Write(a + " ");
            if (M >= 1) Console.Write(b + " ");
            while (b <= M)
            {
                int next = a + b;
                a = b;
                b = next;
                if (b <= M) Console.Write(b + " ");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("M: ");
            int M = int.Parse(Console.ReadLine());
            PrintFibonacciUpTo(M);
        }
    }
}