using System;

namespace Pract4_Task3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.Write(M + " ");
            }
        }
    }
}