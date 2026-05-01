using System;

namespace Pract7_Task11
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
                    matrix[i, j] = rnd.Next(0, 20);
            int maxSum = 0;
            int[] bestRow = new int[m];
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < m; j++)
                    sum += matrix[i, j];
                if (i == 0 || sum > maxSum)
                {
                    maxSum = sum;
                    for (int j = 0; j < m; j++)
                        bestRow[j] = matrix[i, j];
                }
            }
            Console.WriteLine("Строка с макс. суммой: " + string.Join(" ", bestRow));
        }
    }
}