using System;

namespace Pract3_Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год: ");
            int n = int.Parse(Console.ReadLine());
            bool leap = (n % 4 == 0 && n % 100 != 0) || n % 400 == 0;
            if (leap)
                Console.WriteLine("високосный");
            else
                Console.WriteLine("не високосный");
        }
    }
}