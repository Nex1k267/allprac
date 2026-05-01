using System;
using System.IO;

namespace Pract8_Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            string f1 = File.ReadAllText("file1.txt");
            string f2 = File.ReadAllText("file2.txt");
            File.WriteAllText("result.txt", f1 + f2);
        }
    }
}