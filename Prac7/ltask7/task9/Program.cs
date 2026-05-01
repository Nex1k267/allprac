using System;

namespace Pract7_Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[,] matrix = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matrix[i, j] = rnd.Next(0, 50);
            int maxDiag = matrix[0, 0];
            int minDiag = matrix[0, 0];
            int maxIdx = 0, minIdx = 0;
            for (int i = 0; i < n; i++)
            {
                if (matrix[i, i] > maxDiag) { maxDiag = matrix[i, i]; maxIdx = i; }
                if (matrix[i, i] < minDiag) { minDiag = matrix[i, i]; minIdx = i; }
            }
            int temp = matrix[maxIdx, maxIdx];
            matrix[maxIdx, maxIdx] = matrix[minIdx, minIdx];
            matrix[minIdx, minIdx] = temp;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(matrix[i, j] + "\t");
                Console.WriteLine();
            }
        }
    }
}