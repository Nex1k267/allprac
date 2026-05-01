using System;

namespace Pract7_Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matrix[i, j] = rnd.Next(0, 30);
            int maxSumRow = 0;
            int[] bestRow = new int[n];
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < n; j++)
                    sum += matrix[i, j];
                if (i == 0 || sum > maxSumRow)
                {
                    maxSumRow = sum;
                    for (int j = 0; j < n; j++)
                        bestRow[j] = matrix[i, j];
                }
            }
            Console.WriteLine("Строка с макс. суммой: " + string.Join(" ", bestRow));
        }
    }
}