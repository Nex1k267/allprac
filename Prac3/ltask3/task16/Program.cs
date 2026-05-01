using System;

namespace Pract3_Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine());
            if (b != 0 && a % b == 0)
                Console.WriteLine("a является делителем b");
            else
                Console.WriteLine("a НЕ является делителем b");
            if (a != 0 && b % a == 0)
                Console.WriteLine("b является делителем a");
            else
                Console.WriteLine("b НЕ является делителем a");
        }
    }
}