using System;

namespace Pract5_Task19
{
    class Program
    {
        static double HarvestInYear(int N)
        {
            double area = 100;
            double yield = 20;
            for (int i = 2; i <= N; i++)
            {
                area *= 1.05;
                yield *= 1.02;
            }
            return area * yield;
        }

        static double AreaInYear(int N)
        {
            double area = 100;
            for (int i = 2; i <= N; i++)
                area *= 1.05;
            return area;
        }

        static double TotalHarvest(int N)
        {
            double area = 100;
            double yield = 20;
            double total = 0;
            for (int i = 1; i <= N; i++)
            {
                total += area * yield;
                area *= 1.05;
                yield *= 1.02;
            }
            return total;
        }

        static void Main(string[] args)
        {
            Console.Write("N: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Урожайность в " + N + "-й год: " + HarvestInYear(N));
            Console.WriteLine("Площадь в " + N + "-й год: " + AreaInYear(N));
            Console.WriteLine("Урожай за " + N + " лет: " + TotalHarvest(N));
        }
    }
}