using System;

namespace Pract3_Task4_e
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите число y: ");
            double y = double.Parse(Console.ReadLine());
            bool z = x < 0 && y > 5;
            Console.WriteLine(z);
        }
    }
}