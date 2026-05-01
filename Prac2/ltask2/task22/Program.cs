using System;

namespace Pract2_Task22
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = Math.Sqrt(a * a + b * b);
            double P = a + b + c;
            Console.WriteLine(P);
        }
    }
}