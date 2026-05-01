using System;

namespace Pract3_Task5_a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            double B = double.Parse(Console.ReadLine());
            bool D = A > 100 && B > 100;
            Console.WriteLine(D);
        }
    }
}