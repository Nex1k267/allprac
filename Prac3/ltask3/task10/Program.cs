using System;

namespace Pract3_Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите c: ");
            double c = double.Parse(Console.ReadLine());
            double max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            Console.WriteLine("max = " + max);
            double min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            Console.WriteLine("min = " + min);
        }
    }
}