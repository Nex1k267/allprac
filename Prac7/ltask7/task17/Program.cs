using System;

namespace Pract7_Task17
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
                    matrix[i, j] = rnd.Next(0, 3) == 0 ? 0 : rnd.Next(1, 10);
            int lastNonZeroRow = n - 1;
            while (lastNonZeroRow >= 0)
            {
                bool allZero = true;
                for (int j = 0; j < m; j++)
                    if (matrix[lastNonZeroRow, j] != 0) { allZero = false; break; }
                if (!allZero) break;
                lastNonZeroRow--;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] == 0 && i < lastNonZeroRow)
                    {
                        int tmp = matrix[i, j];
                        matrix[i, j] = matrix[lastNonZeroRow, j];
                        matrix[lastNonZeroRow, j] = tmp;
                    }
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