using System;

namespace Pract3_Task23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("d: ");
            int d = int.Parse(Console.ReadLine());

            int count1 = (a / c) * (b / d);
            int count2 = (a / d) * (b / c);

            if (count1 > count2)
                Console.WriteLine("длинной стороной вдоль длинной стороны стола");
            else if (count2 > count1)
                Console.WriteLine("длинной стороной вдоль короткой стороны стола");
            else
                Console.WriteLine("одинаково");
        }
    }
}