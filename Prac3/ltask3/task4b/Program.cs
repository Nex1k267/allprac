using System;

namespace Pract3_Task4_b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число x: ");
            double x = double.Parse(Console.ReadLine());
            bool z = !(x < 2);
            Console.WriteLine(z);
        }
    }
}