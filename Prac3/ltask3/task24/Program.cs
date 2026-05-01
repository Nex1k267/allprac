using System;

namespace Pract3_Task24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("k (6-14): ");
            int k = int.Parse(Console.ReadLine());
            string card = "";
            switch (k)
            {
                case 6: card = "шестерка"; break;
                case 7: card = "семерка"; break;
                case 8: card = "восьмерка"; break;
                case 9: card = "девятка"; break;
                case 10: card = "десятка"; break;
                case 11: card = "валет"; break;
                case 12: card = "дама"; break;
                case 13: card = "король"; break;
                case 14: card = "туз"; break;
            }
            Console.WriteLine(card);
        }
    }
}