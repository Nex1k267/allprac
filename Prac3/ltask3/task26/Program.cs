using System;

namespace Pract3_Task26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("k (1-365): ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("d (1-7): ");
            int d = int.Parse(Console.ReadLine());

            int day = ((k - 1) + (d - 1)) % 7;
            string[] days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
            Console.WriteLine(days[day]);
        }
    }
}