using System;

namespace Pract7_Task12
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
                    matrix[i, j] = rnd.Next(-10, 30);
            for (int i = 0; i < n; i++)
            {
                int minIdx = 0;
                for (int j = 1; j < m; j++)
                    if (matrix[i, j] < matrix[i, minIdx]) minIdx = j;
                if (minIdx != 0)
                {
                    int tmp = matrix[i, 0];
                    matrix[i, 0] = matrix[i, minIdx];
                    matrix[i, minIdx] = tmp;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(matrix[i, j] + "\t");
                Console.WriteLine();
            }
        }
    }
}