using System;

namespace Pract4_Task1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string res = "";
            while (N > 0)
            {
                res = (N % 5) + res;
                N = N / 5;
            }
            Console.WriteLine(res);
        }
    }
}