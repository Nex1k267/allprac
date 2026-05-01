using System;

namespace Pract4_Task1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string binary = "";
            while (N > 0)
            {
                binary = (N % 2) + binary;
                N = N / 2;
            }
            Console.WriteLine(binary);
        }
    }
}