using System;

namespace Pract1_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи свое имя: ");
            string Имя = Console.ReadLine();
            Console.WriteLine("Привет {0}!", Имя);
            Console.Write("Для завершения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}