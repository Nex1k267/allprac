using System;

namespace Pract3_Task5_f
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число X: ");
            int X = int.Parse(Console.ReadLine());
            Console.Write("Введите число Y: ");
            int Y = int.Parse(Console.ReadLine());
            bool D = X % 2 != 0 && Y % 2 != 0;
            Console.WriteLine(D);
        }
    }
}