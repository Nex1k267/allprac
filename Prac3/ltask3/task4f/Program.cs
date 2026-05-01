using System;

namespace Pract3_Task4_f
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число x: ");
            double x = double.Parse(Console.ReadLine());
            bool z = 10 < x && x < 20;
            Console.WriteLine(z);
        }
    }
}