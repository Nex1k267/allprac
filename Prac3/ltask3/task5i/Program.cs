using System;

namespace Pract3_Task5_i
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число X: ");
            double X = double.Parse(Console.ReadLine());
            Console.Write("Введите число Y: ");
            double Y = double.Parse(Console.ReadLine());
            Console.Write("Введите число Z: ");
            double Z = double.Parse(Console.ReadLine());
            bool D = X < 0 && Y < 0 && Z < 0;
            Console.WriteLine(D);
        }
    }
}