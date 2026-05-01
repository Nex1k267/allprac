using System;

namespace Pract4_Task3_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int square = 0;
            for (int i = 1; i <= n; i++)
            {
                square += 2 * i - 1;
            }
            Console.WriteLine(square);
        }
    }
}