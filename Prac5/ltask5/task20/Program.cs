using System;

namespace Pract5_Task20
{
    class Program
    {
        static double Perimeter(double a, double b, double c)
        {
            return a + b + c;
        }

        static void Main(string[] args)
        {
            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine(Perimeter(a, b, c));
        }
    }
}