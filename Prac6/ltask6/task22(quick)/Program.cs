using System;

namespace Pract6_Task22_Quick
{
    class Program
    {
        static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);
                QuickSort(arr, left, pivot - 1);
                QuickSort(arr, pivot + 1, right);
            }
        }

        static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    int tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                }
            }
            int tmp2 = arr[i + 1];
            arr[i + 1] = arr[right];
            arr[right] = tmp2;
            return i + 1;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(100);
            QuickSort(arr, 0, arr.Length - 1);
            foreach (int x in arr)
                Console.Write(x + " ");
        }
    }
}