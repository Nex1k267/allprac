using System;

namespace Pract7_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[6, 11];
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 11; j++)
                    matrix[i, j] = rnd.Next(0, 50);
            int sumMax = 0;
            for (int j = 0; j < 11; j++)
            {
                int max = matrix[0, j];
                for (int i = 1; i < 6; i++)
                    if (matrix[i, j] > max) max = matrix[i, j];
                sumMax += max;
            }
            Console.WriteLine("Сумма максимальных элементов столбцов: " + sumMax);
        }
    }
}