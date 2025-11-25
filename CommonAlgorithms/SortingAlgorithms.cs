using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonAlgorithms
{
    public static class SortingAlgorithms
    {

        public static void BubbleSort(int[] arr)
        {
            bool notSorted = true;
            while (notSorted)
            {
                notSorted = false;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                        notSorted = true;
                    }
                }
            }
        }

        public static void InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        public static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int smallestIndex = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < arr[smallestIndex]) smallestIndex = j;
                }
                int temp = arr[smallestIndex];
                arr[smallestIndex] = arr[i];
                arr[i] = temp;
            }
        }

        public static void QuickSort(int[] arr, int low, int high)
        {
            if (low == high) return;

            if (low < high)
            {
                int pivot = qsPartition(arr, low, high);

                QuickSort(arr, low, pivot - 1);
                QuickSort(arr, pivot + 1, high);
            }


        }

        private static int qsPartition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        public static void MergeSort(int[] arr, int start, int end)
        {
            if (start == end) return;

            int mid = (start + end) / 2;

            MergeSort(arr, start, mid);
            MergeSort(arr, mid + 1, end);

            int[] left = new int[mid - start + 1];
            int[] right = new int[end - mid];
            int i, j;

            for (i = 0; i < left.Length; i++)
            {
                left[i] = arr[start + i];
            }
            for (j = 0; j < right.Length; j++)
            {
                right[j] = arr[mid + 1 + j];
            }

            i = 0; j = 0;
            int k = start;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] < right[j]) arr[k++] = left[i++];
                else arr[k++] = right[j++];
            }

            while (i < left.Length)
            {
                arr[k++] = left[i++];
            }
            while (j < right.Length)
            {
                arr[k++] = right[j++];
            }
        }

    }
}
