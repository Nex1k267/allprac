using System;

namespace Pract2_Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            double V = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double p = m / V;
            Console.WriteLine(p);
        }
    }
}