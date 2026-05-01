using System;

namespace Pract4_Task2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            do
            {
                num = int.Parse(Console.ReadLine());
                sum += num;
            } while (num != 0);
            Console.WriteLine(sum);
        }
    }
}