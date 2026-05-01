using System;

namespace Pract3_Task19
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
            Console.Write("e: ");
            int e = int.Parse(Console.ReadLine());

            int maxCount = 0;

            int cnt1 = (a / c) * (b / d);
            if (cnt1 > maxCount) maxCount = cnt1;

            int cnt2 = (a / d) * (b / c);
            if (cnt2 > maxCount) maxCount = cnt2;

            Console.WriteLine("Наибольшее количество костей: " + maxCount);
        }
    }
}