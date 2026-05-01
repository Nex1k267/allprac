using System;

namespace Pract4_Task3_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int n = 1; n <= 10; n++)
            {
                int square = 0;
                for (int i = 1; i <= n; i++)
                    square += 2 * i - 1;
                sum += square;
            }
            Console.WriteLine(sum);
        }
    }
}