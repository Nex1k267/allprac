using System;
using System.Linq;

namespace Pract6_Task23
{
    class Program
    {
        static int SumOfDigits(int n)
        {
            n = Math.Abs(n);
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        static int LastDigit(int n) => Math.Abs(n) % 10;

        static int FirstDigit(int n)
        {
            n = Math.Abs(n);
            while (n >= 10)
                n /= 10;
            return n;
        }

        static void Main(string[] args)
        {
            int[] arr = { 123, 45, 67, 89, 12, 456 };
            Console.WriteLine("По сумме цифр:");
            foreach (var x in arr.OrderBy(SumOfDigits))
                Console.Write(x + " ");
            Console.WriteLine("\nПо последней цифре:");
            foreach (var x in arr.OrderBy(LastDigit))
                Console.Write(x + " ");
            Console.WriteLine("\nПо первой цифре:");
            foreach (var x in arr.OrderBy(FirstDigit))
                Console.Write(x + " ");
        }
    }
}