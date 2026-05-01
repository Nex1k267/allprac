using System;

namespace Pract7_Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[7, 4];
            Random rnd = new Random();
            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 4; j++)
                    matrix[i, j] = rnd.Next(-20, 10);
            Console.Write("Строки с нечётным отрицательным: ");
            for (int i = 0; i < 7; i++)
            {
                bool has = false;
                for (int j = 0; j < 4; j++)
                    if (matrix[i, j] < 0 && matrix[i, j] % 2 != 0)
                    {
                        has = true;
                        break;
                    }
                if (has) Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}