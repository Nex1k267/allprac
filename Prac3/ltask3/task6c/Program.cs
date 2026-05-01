using System;

namespace Pract3_Task6_c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое N: ");
            int N = int.Parse(Console.ReadLine());
            bool D = N % 5 == 0 || N % 7 == 0;
            Console.WriteLine(D);
        }
    }
}