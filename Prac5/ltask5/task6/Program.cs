using System;

namespace Pract5_Task6
{
    class Program
    {
        static int SquareBySum(int n)
        {
            int square = 0;
            for (int i = 1; i <= n; i++)
                square += 2 * i - 1;
            return square;
        }

        static int SumOfSquares(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
                sum += SquareBySum(i);
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(SumOfSquares(n));
        }
    }
}