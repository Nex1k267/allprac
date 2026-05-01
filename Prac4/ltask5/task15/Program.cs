using System;

namespace Pract5_Task15
{
    class Program
    {
        static double AverageMass(int count)
        {
            double sum = 0;
            for (int i = 0; i < count; i++)
                sum += double.Parse(Console.ReadLine());
            return sum / count;
        }

        static void Main(string[] args)
        {
            Console.Write("Количество предметов: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(AverageMass(n));
        }
    }
}