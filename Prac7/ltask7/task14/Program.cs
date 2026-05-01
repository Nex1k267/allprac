using System;

namespace Pract7_Task14
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
                    matrix[i, j] = rnd.Next(-20, 20);
            int minAbs = Math.Abs(matrix[0, 0]);
            int minRow = 0, minCol = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (Math.Abs(matrix[i, j]) < minAbs)
                    {
                        minAbs = Math.Abs(matrix[i, j]);
                        minRow = i;
                        minCol = j;
                    }
            Console.WriteLine($"Строка: {minRow}, Столбец: {minCol}");
        }
    }
}