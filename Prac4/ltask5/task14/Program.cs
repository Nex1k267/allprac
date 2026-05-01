using System;

namespace Pract5_Task14
{
    class Program
    {
        static double AverageGrade()
        {
            double sum = 0;
            for (int i = 0; i < 10; i++)
                sum += double.Parse(Console.ReadLine());
            return sum / 10;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(AverageGrade());
        }
    }
}