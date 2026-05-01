using System;

namespace Pract3_Task2_a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение A (true/false): ");
            bool A = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение B (true/false): ");
            bool B = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение C (true/false): ");
            bool C = bool.Parse(Console.ReadLine());
            bool res = !(A || !B && C);
            Console.WriteLine($"не ({A} или не {B} и {C}) = {res}");
        }
    }
}