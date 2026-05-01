using System;

namespace Pract5_Task17
{
    class Program
    {
        static double DistanceOnDay(int N)
        {
            double dist = 10;
            for (int i = 2; i <= N; i++)
                dist *= 1.1;
            return dist;
        }

        static double TotalDistance(int N)
        {
            double dist = 10;
            double sum = 10;
            for (int i = 2; i <= N; i++)
            {
                dist *= 1.1;
                sum += dist;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("N: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Пробег за " + N + " день: " + DistanceOnDay(N));
            Console.WriteLine("Суммарный путь за " + N + " дней: " + TotalDistance(N));
        }
    }
}