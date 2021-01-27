using System;
using System.Collections.Concurrent;

namespace AlgoPractice
{
    static class Program
    {
        static void Main(string[] args)
        {
            int[] array = GenArray();
            PrintArray(array);
            array = new QuickSort().quickSort(array, 0, array.Length - 1);
            PrintArray(array);
            int l = 0;
            int r = array.Length - 1;
            int x = 0;
            Console.WriteLine("\n" + new BinarySearch().binarySearch(array, l, r, x));
        }

        private static int[] GenArray()
        {
            Random random = new Random();
            int[] arr = new int[50];
            for (int i = 0; i < 50; i++)
            {
                arr[i] = random.Next(50);
            }

            return arr;
        }

        private static void PrintArray(int[] arr)
        {
            
            Console.WriteLine();
            foreach (var t in arr)
            {
                Console.Write(t + ", ");
            }
        }
    }
}