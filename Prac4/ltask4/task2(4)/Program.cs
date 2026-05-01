using System;

namespace Pract4_Task2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num;
            int count = 0;
            do
            {
                num = rnd.Next(1, 11);
                Console.Write(num + " ");
                count++;
            } while (num != 7);
            Console.WriteLine("\n" + count);
        }
    }
}