using System;

namespace Pract4_Task2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            int count = 0;
            do
            {
                num = int.Parse(Console.ReadLine());
                sum += num;
                count++;
            } while (num != 0);
            Console.WriteLine(sum / (count - 1));
        }
    }
}