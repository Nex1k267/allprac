using System;

namespace Pract2_Task23
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double arith = (Math.Abs(a) + Math.Abs(b)) / 2.0;
            double geom = Math.Sqrt(Math.Abs(a) * Math.Abs(b));
            Console.WriteLine("Среднее арифметическое модулей: " + arith);
            Console.WriteLine("Среднее геометрическое модулей: " + geom);
        }
    }
}