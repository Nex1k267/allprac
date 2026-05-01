using System;

namespace Pract3_Task28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());

            int prevDay = n - 1;
            int prevMonth = m;
            if (prevDay == 0)
            {
                prevMonth = m - 1;
                if (prevMonth == 0) prevMonth = 12;
                int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                prevDay = daysInMonth[prevMonth - 1];
            }
            Console.WriteLine("Предыдущий день: " + prevDay + "." + prevMonth);

            int nextDay = n + 1;
            int nextMonth = m;
            int[] daysInMonth2 = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (nextDay > daysInMonth2[m - 1])
            {
                nextDay = 1;
                nextMonth = m + 1;
                if (nextMonth > 12) nextMonth = 1;
            }
            Console.WriteLine("Следующий день: " + nextDay + "." + nextMonth);
        }
    }
}