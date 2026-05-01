using System;
using System.IO;

namespace Pract8_Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = File.ReadAllText("book.txt");
            Console.WriteLine("Символов: " + content.Length);
            Console.WriteLine("Слов: " + content.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length);
            Console.WriteLine("Строк: " + content.Split('\n').Length);
        }
    }
}