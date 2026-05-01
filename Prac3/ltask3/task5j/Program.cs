using System;

namespace Pract3_Task5_j
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число X: ");
            int X = int.Parse(Console.ReadLine());
            Console.Write("Введите число Y: ");
            int Y = int.Parse(Console.ReadLine());
            Console.Write("Введите число Z: ");
            int Z = int.Parse(Console.ReadLine());
            bool D = (X % 5 == 0 && Y % 5 != 0 && Z % 5 != 0) || (Y % 5 == 0 && X % 5 != 0 && Z % 5 != 0) || (Z % 5 == 0 && X % 5 != 0 && Y % 5 != 0);
            Console.WriteLine(D);
        }
    }
}