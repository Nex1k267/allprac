using System;

namespace Pract8_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(new string(arr));
        }
    }
}