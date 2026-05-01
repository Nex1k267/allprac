using System;

namespace Pract7_Task2
{
    class Program
    {
        static void PrintArray(int[] arr)
        {
            foreach (int item in arr)
                Console.Write(item + " ");
            Console.WriteLine();
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j] + "\t");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[] array1d = { 1, 2, 3, 4 };
            int[,] array2d = { { 1, 2 }, { 3, 4 } };
            PrintArray(array1d);
            PrintMatrix(array2d);
        }
    }
}