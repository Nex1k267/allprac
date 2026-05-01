using System;

namespace Pract3_Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Расстояние в км: ");
            double km = double.Parse(Console.ReadLine());
            Console.Write("Расстояние в футах: ");
            double ft = double.Parse(Console.ReadLine());
            double m_km = km * 1000;
            double m_ft = ft * 0.305;
            if (m_km < m_ft)
                Console.WriteLine("км меньше");
            else if (m_ft < m_km)
                Console.WriteLine("футы меньше");
            else
                Console.WriteLine("равны");
        }
    }
}