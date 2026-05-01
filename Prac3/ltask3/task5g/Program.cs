using System;

namespace Pract3_Task5_g
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число X: ");
            int X = int.Parse(Console.ReadLine());
            Console.Write("Введите число Y: ");
            int Y = int.Parse(Console.ReadLine());
            bool D = (X < 20 && Y >= 20) || (Y < 20 && X >= 20);
            Console.WriteLine(D);
        }
    }
}