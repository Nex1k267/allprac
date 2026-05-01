using System;

namespace Pract7_Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[4, 6];
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 6; j++)
                    matrix[i, j] = rnd.Next(0, 20);
            int[] rowSums = new int[4];
            for (int i = 0; i < 4; i++)
            {
                int sum = 0;
                for (int j = 0; j < 6; j++)
                    sum += matrix[i, j];
                rowSums[i] = sum;
            }
            Console.WriteLine("Суммы строк: " + string.Join(" ", rowSums));
            int maxSum = rowSums[0];
            for (int i = 1; i < 4; i++)
                if (rowSums[i] > maxSum) maxSum = rowSums[i];
            Console.WriteLine("Максимальная сумма: " + maxSum);
        }
    }
}