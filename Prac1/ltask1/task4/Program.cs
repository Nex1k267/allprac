using System;

namespace Pract1_Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи свое имя: ");
            string Имя = Console.ReadLine();
            Console.Write("Привет " + Имя + "!\nДля завершения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}