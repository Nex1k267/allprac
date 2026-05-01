using System;

namespace Pract5_Task18
{
    class Program
    {
        static double PositionAfterNSteps(int N)
        {
            double pos = 0;
            int sign = 1;
            for (int i = 1; i <= N; i++)
            {
                pos += sign * (1.0 / i);
                sign = -sign;
            }
            return pos + 1;
        }

        static double TotalPath(int N)
        {
            double path = 0;
            for (int i = 1; i <= N; i++)
                path += 1.0 / i;
            return path;
        }

        static void Main(string[] args)
        {
            Console.Write("N: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Расстояние от дома: " + PositionAfterNSteps(N));
            Console.WriteLine("Общий путь: " + TotalPath(N));
        }
    }
}