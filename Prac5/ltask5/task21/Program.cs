using System;

namespace Pract5_Task21
{
    class Program
    {
        static double GetPow(double number, int power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
                result *= number;
            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Число: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Степень: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetPow(a, n));
        }
    }
}