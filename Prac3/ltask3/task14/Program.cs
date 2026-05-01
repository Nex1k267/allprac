using System;

namespace Pract3_Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");
            int N = int.Parse(Console.ReadLine());
            if (N % 2 == 0)
                Console.WriteLine("заканчивается четной цифрой");
            else
                Console.WriteLine("заканчивается нечетной цифрой");
        }
    }
}