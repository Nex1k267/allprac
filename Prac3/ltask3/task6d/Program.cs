using System;

namespace Pract3_Task6_d
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое N: ");
            int N = int.Parse(Console.ReadLine());
            bool D = N % 4 == 0 && N % 10 != 0;
            Console.WriteLine(D);
        }
    }
}