using System;

namespace Pract3_Task25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("m (1-4): ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("k (6-14): ");
            int k = int.Parse(Console.ReadLine());

            string mast = "";
            switch (m)
            {
                case 1: mast = "пик"; break;
                case 2: mast = "треф"; break;
                case 3: mast = "бубен"; break;
                case 4: mast = "червей"; break;
            }

            string dost = "";
            switch (k)
            {
                case 6: dost = "шестерка"; break;
                case 7: dost = "семерка"; break;
                case 8: dost = "восьмерка"; break;
                case 9: dost = "девятка"; break;
                case 10: dost = "десятка"; break;
                case 11: dost = "валет"; break;
                case 12: dost = "дама"; break;
                case 13: dost = "король"; break;
                case 14: dost = "туз"; break;
            }

            Console.WriteLine(dost + " " + mast);
        }
    }
}