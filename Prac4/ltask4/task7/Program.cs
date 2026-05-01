using System;

namespace Pract4_Task3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum / 10);
        }
    }
}