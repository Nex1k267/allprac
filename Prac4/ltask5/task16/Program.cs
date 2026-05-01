using System;

namespace Pract5_Task16
{
    class Program
    {
        static int MonthsToReach(double deposit, double percent, double target)
        {
            int months = 0;
            while (deposit < target)
            {
                months++;
                deposit += deposit * percent / 100;
            }
            return months;
        }

        static void Main(string[] args)
        {
            Console.Write("Вклад: ");
            double N = double.Parse(Console.ReadLine());
            Console.Write("Процент: ");
            double p = double.Parse(Console.ReadLine());
            Console.Write("Необходимая сумма: ");
            double S = double.Parse(Console.ReadLine());
            Console.WriteLine(MonthsToReach(N, p, S));
        }
    }
}