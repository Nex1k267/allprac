using System;

namespace Pract3_Task20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("k (1-365): ");
            int k = int.Parse(Console.ReadLine());
            int day = (k - 1) % 7;
            if (day >= 5)
                Console.WriteLine("выходной");
            else
                Console.WriteLine("рабочий");
        }
    }
}