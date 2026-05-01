using System;

namespace Pract8_Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string oldStr = Console.ReadLine();
            string newStr = Console.ReadLine();
            Console.WriteLine(s.Replace(oldStr, newStr));
        }
    }
}