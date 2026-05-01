using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Pract8_Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = File.ReadAllText("secret.txt");
            string result = Regex.Replace(content, "[a-zA-Zа-яА-ЯёЁ]", "*");
            File.WriteAllText("encrypted.txt", result);
        }
    }
}