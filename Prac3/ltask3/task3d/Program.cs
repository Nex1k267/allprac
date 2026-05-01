using System;

namespace Pract3_Task3_d
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение X (true/false): ");
            bool X = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение Y (true/false): ");
            bool Y = bool.Parse(Console.ReadLine());
            bool res = !(X == Y) || Y;
            Console.WriteLine($"(X ≡ Y) → Y = {res}");
        }
    }
}