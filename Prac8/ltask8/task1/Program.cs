using System;

namespace Pract8_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (char.IsDigit(ch))
                Console.WriteLine("цифра");
            else if (char.IsLetter(ch))
                Console.WriteLine("буква");
            else
                Console.WriteLine("спецсимвол");
        }
    }
}