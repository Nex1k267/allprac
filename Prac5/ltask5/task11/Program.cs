using System;

namespace Pract5_Task11
{
    class Program
    {
        static int FromBaseToDecimal(string s, int b)
        {
            int dec = 0;
            int pow = 1;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                dec += (s[i] - '0') * pow;
                pow *= b;
            }
            return dec;
        }

        static void Main(string[] args)
        {
            Console.Write("Число в системе: ");
            string s = Console.ReadLine();
            Console.Write("Основание (2-10): ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(FromBaseToDecimal(s, b));
        }
    }
}