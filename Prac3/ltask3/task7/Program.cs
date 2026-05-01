using System;

namespace Pract3_Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine());
            double y;
            if (x > 0)
                y = Math.Sin(x);
            else
                y = Math.Cos(x);
            Console.WriteLine(y);
        }
    }
}