using System;

namespace Pract4_Task2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
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
    }
}