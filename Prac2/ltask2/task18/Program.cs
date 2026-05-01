using System;

namespace Pract2_Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double x = -b / a;
            Console.WriteLine(x);
        }
    }
}