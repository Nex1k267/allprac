using System;

namespace Pract3_Task3_g
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение X (true/false): ");
            bool X = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение Y (true/false): ");
            bool Y = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение Z (true/false): ");
            bool Z = bool.Parse(Console.ReadLine());
            bool res = !Y || (Z == X);
            Console.WriteLine($"Y → (Z ≡ X) = {res}");
        }
    }
}