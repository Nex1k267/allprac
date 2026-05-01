using System;

namespace Pract3_Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = double.Parse(Console.ReadLine());
            if (a > b)
                Console.WriteLine("больше " + a);
            else if (b > a)
                Console.WriteLine("больше " + b);
            else
                Console.WriteLine("равны");
        }
    }
}