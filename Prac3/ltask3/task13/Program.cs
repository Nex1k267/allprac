using System;

namespace Pract3_Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Скорость в км/ч: ");
            double kmh = double.Parse(Console.ReadLine());
            Console.Write("Скорость в м/с: ");
            double ms = double.Parse(Console.ReadLine());
            double kmh_to_ms = kmh / 3.6;
            if (kmh_to_ms > ms)
                Console.WriteLine("км/ч больше");
            else if (ms > kmh_to_ms)
                Console.WriteLine("м/с больше");
            else
                Console.WriteLine("равны");
        }
    }
}