using System;

namespace Pract2_Task21
{
    class Program
    {
        static void Main(string[] args)
        {
            double R = double.Parse(Console.ReadLine());
            double r = double.Parse(Console.ReadLine());
            double S = Math.PI * (R * R - r * r);
            Console.WriteLine(S);
        }
    }
}