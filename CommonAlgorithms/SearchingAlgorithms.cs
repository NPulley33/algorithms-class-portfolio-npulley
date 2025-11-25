using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonAlgorithms
{
    public static class SearchingAlgorithms
    {

        public static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target) return i;
            }
            return -1;
        }

        public static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            { 
                int mid = (left + right) / 2;
                if (arr[mid] == target) return mid;
                if (arr[mid] < target) left = mid + 1;
                else right = mid - 1;
            }
            return -1;
        }

        public static int InterpolationSearch(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;
            int position = 0;

            while (low < high && target >= arr[low] && target <= arr[high])
            {
                position = low + ((target - arr[low]) * (high - low) / (arr[high] - arr[low]) );

                if (arr[position] == target) return position;
                if (arr[position] < target) low = position + 1;
                else high = position - 1;
            }

            return -1;
        }

    }
}
