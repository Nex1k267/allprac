using System;
using System.Linq;

namespace Pract6_Task19_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            int nSize = int.Parse(Console.ReadLine());
            int[] n = new int[nSize];
            for (int i = 0; i < nSize; i++)
                n[i] = int.Parse(Console.ReadLine());
            Console.Write("m: ");
            int mSize = int.Parse(Console.ReadLine());
            int[] m = new int[mSize];
            for (int i = 0; i < mSize; i++)
                m[i] = int.Parse(Console.ReadLine());
            int[] union = n.Union(m).ToArray();
            int[] intersect = n.Intersect(m).ToArray();
            int[] result = union.Except(intersect).ToArray();
            foreach (int x in result)
                Console.Write(x + " ");
        }
    }
}