using System;

namespace Pract3_Task27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n (месяцев): ");
            int n = int.Parse(Console.ReadLine());
            int month = n % 12;
            string[] months = { "январь", "февраль", "март", "апрель", "май", "июнь", "июль", "август", "сентябрь", "октябрь", "ноябрь", "декабрь" };
            Console.WriteLine(months[month]);
        }
    }
}