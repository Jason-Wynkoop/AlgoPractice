
namespace AlgoPractice
{
    public class BinarySearch
    {
        public BinarySearch()
        {
            
        }

        public int binarySearch(int[] arr, int min, int max, int x)
        {
            
            //if this is false, target does not exist. 
            if (max >= min)
            {
                
                //Setting up mid
                int mid = min + (max - min) / 2;

                //if mid == max then target found at mid
                if (mid == x) return mid;
                
                //if number at mid is greater than the target, then return left side of array
                if (arr[mid] > x)
                {
                    return binarySearch(arr, min, mid - 1, x);
                }

                //if number at mid is less than the target, then return right side of array
                return binarySearch(arr, mid + 1, max, x);
            }

            return -1;
        }
    }
}