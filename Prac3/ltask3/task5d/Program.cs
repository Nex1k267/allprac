using System;

namespace Pract3_Task5_d
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Введите число C: ");
            int C = int.Parse(Console.ReadLine());
            bool D = (A < 50 && B >= 50 && C >= 50) || (B < 50 && A >= 50 && C >= 50) || (C < 50 && A >= 50 && B >= 50);
            Console.WriteLine(D);
        }
    }
}