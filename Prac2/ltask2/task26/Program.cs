using System;

namespace Pract2_Task26
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = b = c = 2;

            
            double z = a * b + c++ / b - a * b * --c;
            Console.WriteLine("Исходное: " + z);

            
            a = b = c = 2;
            double z1 = (a * b) + (double)(c++) / b - a * b * (--c);
            
            a = b = c = 2;
            int c1 = c++;
            double expr1 = a * b + (double)c1 / b - a * b * (c - 1); // c после ++ стало 3, затем --c сделает 2
            Console.WriteLine(expr1); 
            
            Console.WriteLine("Варианты: подобрать скобки, чтобы получить нужный результат.");
            
        }
    }
}