using System;

namespace Pract3_Task1_b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение А (true/false): ");
            bool A = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение B (true/false): ");
            bool B = bool.Parse(Console.ReadLine());
            bool C = !(!A || !B) || A;
            Console.WriteLine($"не (не {A} или не {B}) или {A} = {C}");
        }
    }
}