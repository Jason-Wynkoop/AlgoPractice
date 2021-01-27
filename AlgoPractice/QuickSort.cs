using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;

namespace AlgoPractice
{
    public class QuickSort
    {

        /// <summary>
        ///The main function that implements quick sort.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        public int[] quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                //pivot_index is partitioning index, arr[pivot_index] is now at correct place in sorted array
                int pivotIndex = Partition(arr, low, high);

                quickSort(arr, low, pivotIndex - 1); //before pivot index
                quickSort(arr, pivotIndex + 1, high); //After pivot index
            }

            return arr;
        }

        /// <summary>
        ///The function selects the last element as pivot element, places that pivot element correctly in the array
        /// in such a way that all the elements to the left of the pivot are lesser than the pivot and all
        /// the elements to the tight of pivot are greater than it.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private int Partition(int[] arr, int low, int high)
        {
            //pivot - Element at right most position
            int pivot = arr[high];
            
            int i = (low - 1); //Index of smaller element
            for (int j = low; j < high; j++)
            {
                //If the current element is smaller than the pivot, swap the element with pivot
                if (arr[j] < pivot)
                {
                    i++;
                    
                    //swap arr[i] with arr[j]
                    int temp1 = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp1;
                }
            }
            
            //swap arr[i+1] and arr[high] (or pivot)
            int temp = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp;


            return i + 1;
        }
    }
}