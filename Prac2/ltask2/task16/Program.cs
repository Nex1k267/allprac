using System;

namespace Pract2_Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            double arith = (x + y) / 2.0;
            double geom = Math.Sqrt(x * y);
            Console.WriteLine("Среднее арифметическое: " + arith);
            Console.WriteLine("Среднее геометрическое: " + geom);
        }
    }
}