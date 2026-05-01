using System;

namespace Pract4_Task1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double summa = double.Parse(Console.ReadLine());
            int n = 0;
            while (summa < 100000)
            {
                n++;
                summa += summa * 0.02;
            }
            Console.WriteLine(n);
        }
    }
}