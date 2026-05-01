using System;
using System.IO;
using System.Collections.Generic;

namespace Pract8_Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("data.txt");
            List<string> filtered = new List<string>();
            foreach (string line in lines)
                if (line.Length >= 5) filtered.Add(line);
            File.WriteAllLines("filtered.txt", filtered);
        }
    }
}