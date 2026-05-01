using System;

namespace Pract7_Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("M: ");
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    matrix[i, j] = rnd.Next(0, 30);
            Console.Write("Порог: ");
            double threshold = double.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                double sum = 0;
                for (int j = 0; j < m; j++)
                    sum += matrix[i, j];
                if (sum / m < threshold) count++;
            }
            Console.WriteLine("Количество строк: " + count);
        }
    }
}