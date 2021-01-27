using System;

namespace AlgoPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1, 2, 3, 4, 4, 5, 6, 9, 10, 14, 67};
            int l = 0;
            int r = array.Length - 1;
            int x = 10;
            Console.WriteLine(new BinarySearch().binarySearch(array, l, r, x));
        }
    }
}