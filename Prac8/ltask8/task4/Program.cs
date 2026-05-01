using System;

namespace Pract8_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = char.ToLower(Console.ReadLine()[0]);
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'y')
                Console.WriteLine("гласная");
            else
                Console.WriteLine("не гласная");
        }
    }
}