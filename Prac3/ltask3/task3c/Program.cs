using System;

namespace Pract3_Task3_c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение X (true/false): ");
            bool X = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение Y (true/false): ");
            bool Y = bool.Parse(Console.ReadLine());
            bool res = (X && Y) || (!Y || X);
            Console.WriteLine($"(X ∧ Y) ∨ (Y → X) = {res}");
        }
    }
}