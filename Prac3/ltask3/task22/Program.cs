using System;

namespace Pract3_Task22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("t (минут): ");
            double t = double.Parse(Console.ReadLine());
            double cycle = t % 5;
            if (cycle < 3)
                Console.WriteLine("зеленый");
            else
                Console.WriteLine("красный");
        }
    }
}