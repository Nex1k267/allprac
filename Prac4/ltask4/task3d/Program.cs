using System;

namespace Pract4_Task3_3_b
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = int.Parse(Console.ReadLine());
            for (int i = 10; i <= b; i++)
                Console.WriteLine(i * i);
        }
    }
}