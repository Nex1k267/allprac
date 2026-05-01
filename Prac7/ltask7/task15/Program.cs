using System;

namespace Pract7_Task15
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
                    matrix[i, j] = rnd.Next(-5, 15);
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());
            int[] linear = new int[n * m];
            int idx = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (matrix[i, j] < a || matrix[i, j] > b)
                        linear[idx++] = matrix[i, j];
            while (idx < linear.Length)
                linear[idx++] = 0;
            Console.WriteLine("Результат: " + string.Join(" ", linear));
        }
    }
}