using System;

namespace Pract3_Task4_g
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число x: ");
            double x = double.Parse(Console.ReadLine());
            bool z = x > 3 || x < 1;
            Console.WriteLine(z);
        }
    }
}