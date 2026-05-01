using System;

namespace Pract3_Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1 левого нижнего угла первого: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1 левого нижнего угла первого: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("ширина первого: ");
            double w1 = double.Parse(Console.ReadLine());
            Console.Write("высота первого: ");
            double h1 = double.Parse(Console.ReadLine());

            Console.Write("x2 левого нижнего угла второго: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2 левого нижнего угла второго: ");
            double y2 = double.Parse(Console.ReadLine());
            Console.Write("ширина второго: ");
            double w2 = double.Parse(Console.ReadLine());
            Console.Write("высота второго: ");
            double h2 = double.Parse(Console.ReadLine());

            bool firstInSecond = x1 >= x2 && y1 >= y2 && x1 + w1 <= x2 + w2 && y1 + h1 <= y2 + h2;
            bool secondInFirst = x2 >= x1 && y2 >= y1 && x2 + w2 <= x1 + w1 && y2 + h2 <= y1 + h1;

            bool intersect = !(x1 + w1 < x2 || x2 + w2 < x1 || y1 + h1 < y2 || y2 + h2 < y1);

            if (firstInSecond) Console.WriteLine("первый внутри второго");
            if (secondInFirst) Console.WriteLine("второй внутри первого");
            if (intersect) Console.WriteLine("пересекаются");
            if (!firstInSecond && !secondInFirst && !intersect) Console.WriteLine("не пересекаются");
        }
    }
}