using System;

namespace Pract3_Task6_a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое A: ");
            int A = int.Parse(Console.ReadLine());
            bool D = A % 2 == 0 || A % 3 == 0;
            Console.WriteLine(D);
        }
    }
}