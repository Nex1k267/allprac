using System;

namespace Pract6_Task22_Bubble
{
    class Program
    {
        static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = 0; j < arr.Length - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        int t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;
                    }
        }

        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(100);
            BubbleSort(arr);
            foreach (int x in arr)
                Console.Write(x + " ");
        }
    }
}