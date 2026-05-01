using System;

namespace Pract5_Task25
{
    class Program
    {
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        static int Sum(int a, int b, int c, int d)
        {
            return a + b + c + d;
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
            Console.WriteLine("Сумма двух: " + Sum(a, b));
            Console.WriteLine("Сумма трех: " + Sum(a, b, c));
            Console.WriteLine("Сумма четырех: " + Sum(a, b, c, d));
        }
    }
}