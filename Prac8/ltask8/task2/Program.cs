using System;

namespace Pract8_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = Console.ReadLine()[0];
            if (char.IsLower(ch))
                Console.WriteLine(char.ToUpper(ch));
            else
                Console.WriteLine(char.ToLower(ch));
        }
    }
}