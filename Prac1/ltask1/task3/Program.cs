using System;

namespace Pract1_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("C# --- это современный,");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("с открытым исходным кодом,");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("объектно-ориентированный");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("язык программирования.");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}