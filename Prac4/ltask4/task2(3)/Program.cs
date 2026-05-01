using System;

namespace Pract4_Task2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                num = int.Parse(Console.ReadLine());
            } while (num < 1 || num > 100);
            Console.WriteLine(num);
        }
    }
}