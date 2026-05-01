using System;

namespace Pract2_Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 3.2f;
            decimal b = 2.6m;
            double c = 4.5;
            c = (double)(a + (float)Convert.ToDouble(b) + c);
            Console.WriteLine(c);
        }
    }
}