using System;

namespace Pract2_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            Console.WriteLine(rnd.Next(a, b + 1));
        }
    }
}