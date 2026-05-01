using System;

namespace Pract4_Task3_3_c
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for (int i = a; i <= 50; i++)
                Console.WriteLine(i * i * i);
        }
    }
}