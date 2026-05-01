using System;

namespace Pract2_Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(number, 2));
        }
    }
}