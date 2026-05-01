using System;

namespace Pract8_Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine().Trim();
            if (s == "") { Console.WriteLine(0); return; }
            string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(words.Length);
        }
    }
}