using System;
using System.IO;

namespace Pract8_Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = File.ReadAllText("input.txt");
            Console.WriteLine(content);
        }
    }
}