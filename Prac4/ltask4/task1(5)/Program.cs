using System;

namespace Pract4_Task1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N2 = int.Parse(Console.ReadLine());
            int dec = 0;
            int pow = 1;
            while (N2 > 0)
            {
                int digit = N2 % 10;
                dec += digit * pow;
                pow *= 2;
                N2 = N2 / 10;
            }
            Console.WriteLine(dec);
        }
    }
}