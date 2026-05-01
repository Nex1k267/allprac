using System;

namespace Pract3_Task4_d
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число x: ");
            double x = double.Parse(Console.ReadLine());
            bool z = !(x < 0 && x < 5);
            Console.WriteLine(z);
        }
    }
}