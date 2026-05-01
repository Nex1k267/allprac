using System;

namespace Pract3_Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Радиус круга: ");
            double R = double.Parse(Console.ReadLine());
            Console.Write("Сторона квадрата: ");
            double a = double.Parse(Console.ReadLine());
            double S_circle = Math.PI * R * R;
            double S_square = a * a;
            if (S_circle > S_square)
                Console.WriteLine("площадь круга больше");
            else if (S_square > S_circle)
                Console.WriteLine("площадь квадрата больше");
            else
                Console.WriteLine("равны");
        }
    }
}