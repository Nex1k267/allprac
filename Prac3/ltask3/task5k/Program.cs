using System;

namespace Pract3_Task5_k
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
            bool D = X > 100 || Y > 100 || Z > 100;
            Console.WriteLine(D);
        }
    }
}