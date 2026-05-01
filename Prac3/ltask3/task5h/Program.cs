using System;

namespace Pract3_Task5_h
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число X: ");
            int X = int.Parse(Console.ReadLine());
            Console.Write("Введите число Y: ");
            int Y = int.Parse(Console.ReadLine());
            bool D = X == 0 || Y == 0;
            Console.WriteLine(D);
        }
    }
}