using System;

namespace Pract7_Task1
{
    class Program
    {
        static int[,] GenerateMatrix(int rows, int cols, int min, int max)
        {
            int[,] matrix = new int[rows, cols];
            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = rnd.Next(min, max + 1);
            return matrix;
        }

        static void Main(string[] args)
        {
            int[,] mat = GenerateMatrix(4, 5, -10, 20);
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                    Console.Write(mat[i, j] + "\t");
                Console.WriteLine();
            }
        }
    }
}