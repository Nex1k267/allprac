using System;

namespace Pract3_Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = double.Parse(Console.ReadLine());
            double max = a > b ? a : b;
            double min = a < b ? a : b;
            Console.WriteLine("max = " + max);
            Console.WriteLine("min = " + min);
        }
    }
}