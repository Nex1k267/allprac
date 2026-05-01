using System;

namespace Pract7_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 8];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 8; j++)
                    matrix[i, j] = rnd.Next(-10, 30);
            Console.Write("Столбцы с отрицательными: ");
            for (int j = 0; j < 8; j++)
            {
                bool hasNegative = false;
                for (int i = 0; i < 5; i++)
                    if (matrix[i, j] < 0)
                    {
                        hasNegative = true;
                        break;
                    }
                if (hasNegative) Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}