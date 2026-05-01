using System;

namespace Pract5_Task24
{
    class Program
    {
        static int Min(int a, int b)
        {
            return a < b ? a : b;
        }

        static int Min(int a, int b, int c)
        {
            return Min(Min(a, b), c);
        }

        static int Min(int a, int b, int c, int d)
        {
            return Min(Min(a, b, c), d);
        }

        static int Min(int a, int b, int c, int d, int e)
        {
            return Min(Min(a, b, c, d), e);
        }

        static void Main(string[] args)
        {
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("d: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("e: ");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("Min из 3: " + Min(a, b, c));
            Console.WriteLine("Min из 4: " + Min(a, b, c, d));
            Console.WriteLine("Min из 5: " + Min(a, b, c, d, e));
        }
    }
}