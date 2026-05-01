using System;

namespace Pract7_Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 10];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 10; j++)
                    matrix[i, j] = rnd.Next(-5, 20);
            Console.Write("Строки только с положительными: ");
            for (int i = 0; i < 5; i++)
            {
                bool allPositive = true;
                for (int j = 0; j < 10; j++)
                    if (matrix[i, j] <= 0)
                    {
                        allPositive = false;
                        break;
                    }
                if (allPositive) Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}