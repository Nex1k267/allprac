using System;

namespace Pract8_Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string result = "";
            foreach (char c in s)
                if (!char.IsDigit(c))
                    result += c;
            Console.WriteLine(result);
        }
    }
}