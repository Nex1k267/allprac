using System;

namespace Pract2_Task25
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int d1 = num % 10;
            int d2 = (num / 10) % 10;
            int d3 = (num / 100) % 10;
            int d4 = num / 1000;
            int sum = d1 + d2 + d3 + d4;
            int prod = d1 * d2 * d3 * d4;
            Console.WriteLine("Сумма цифр: " + sum);
            Console.WriteLine("Произведение цифр: " + prod);
        }
    }
}