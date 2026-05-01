using System;

namespace Pract7_Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[8, 5];
            Random rnd = new Random();
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 5; j++)
                    matrix[i, j] = rnd.Next(20, 41);
            int targetRow = -1;
            for (int i = 0; i < 8; i++)
            {
                int evenCount = 0;
                for (int j = 0; j < 5; j++)
                    if (matrix[i, j] % 2 == 0) evenCount++;
                if (evenCount <= 3)
                {
                    targetRow = i;
                    break;
                }
            }
            Console.WriteLine("Номер строки: " + targetRow);
        }
    }
}