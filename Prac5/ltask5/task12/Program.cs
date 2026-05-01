using System;

namespace Pract5_Task12
{
    class Program
    {
        static int ReadNumberInRange()
        {
            int num;
            do
            {
                num = int.Parse(Console.ReadLine());
            } while (num < 1 || num > 100);
            return num;
        }

        static void Main(string[] args)
        {
            int result = ReadNumberInRange();
            Console.WriteLine(result);
        }
    }
}