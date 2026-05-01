using System;

namespace Pract3_Task5_c
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
            bool D = A % 3 == 0 && B % 3 == 0 && C % 3 == 0;
            Console.WriteLine(D);
        }
    }
}