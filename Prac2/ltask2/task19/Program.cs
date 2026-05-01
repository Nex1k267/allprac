using System;

namespace Pract2_Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double d = b * b - 4 * a * (c - e);
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }
    }
}