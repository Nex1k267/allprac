using System;

namespace Pract6_Task22_Selection
{
    class Program
    {
        static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                if (minIndex != i)
                {
                    int t = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = t;
                }
            }
        }

        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(100);
            SelectionSort(arr);
            foreach (int x in arr)
                Console.Write(x + " ");
        }
    }
}