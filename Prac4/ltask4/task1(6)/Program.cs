using System;

namespace Pract4_Task1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N7 = int.Parse(Console.ReadLine());
            int dec = 0;
            int pow = 1;
            while (N7 > 0)
            {
                int digit = N7 % 10;
                dec += digit * pow;
                pow *= 7;
                N7 = N7 / 10;
            }
            Console.WriteLine(dec);
        }
    }
}