using System;

namespace Pract2_Task24
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

          
            int a4 = a * a;
            a4 = a4 * a4;
            Console.WriteLine("a^4 = " + a4);

            
            int a2 = a * a;
            int a4_2 = a2 * a2;
            int a6 = a4_2 * a2;
            Console.WriteLine("a^6 = " + a6);

            int a3 = a2 * a;
            int a7 = a4_2 * a3;
            Console.WriteLine("a^7 = " + a7);

           
            int a8 = a4 * a4;
            Console.WriteLine("a^8 = " + a8);

            
            int a9 = a8 * a;
            Console.WriteLine("a^9 = " + a9);

      
            int a5 = a3 * a2;
            int a10 = a5 * a5;
            Console.WriteLine("a^10 = " + a10);
        }
    }
}