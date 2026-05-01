using System;
using System.IO;

namespace Pract8_Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string content = File.ReadAllText("text.txt");
            string[] words = content.Split(new char[] { ' ', '\n', '\r', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            foreach (string w in words)
                if (w.ToLower() == word.ToLower()) count++;
            Console.WriteLine(count);
        }
    }
}