using System;

namespace Pract3_Task21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = double.Parse(Console.ReadLine());
            double max, min;
            if (a > b)
            {
                max = a;
                min = b;
            }
            else
            {
                max = b;
                min = a;
            }
            Console.WriteLine("max = " + max);
            Console.WriteLine("min = " + min);
        }
    }
}