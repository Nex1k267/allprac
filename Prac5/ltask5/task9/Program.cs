using System;

namespace Pract5_Task9
{
    class Program
    {
        static void PrintDigits(int n)
        {
            while (n > 0)
            {
                Console.WriteLine(n % 10);
                n /= 10;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите N: ");
            int N = int.Parse(Console.ReadLine());
            PrintDigits(N);
        }
    }
}