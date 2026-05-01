using System;

namespace Pract5_Task10
{
    class Program
    {
        static string ConvertToBase(int n, int b)
        {
            string res = "";
            while (n > 0)
            {
                res = (n % b) + res;
                n /= b;
            }
            return res;
        }

        static void Main(string[] args)
        {
            Console.Write("Число: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Система счисления (2-10): ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(ConvertToBase(n, b));
        }
    }
}