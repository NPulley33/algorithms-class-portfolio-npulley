using algo_class_portfolio_npulley;
using KarlTeaching;

namespace UnitTests
{
    public class SortingTests
    {
        [Fact]
        public void BubbleSortTest()
        {
            int[] arr = { 3, 5, 4, 6, 2, 7, 1, 8};
            SortingAlgorithms.BubbleSort(arr);

            bool isSorted = true;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1]) isSorted = false;
            }

            Assert.True(isSorted);
        }

        [Fact]
        public void InsertionSortTest()
        {
            int[] arr = { 3, 5, 4, 6, 2, 7, 1, 8 };
            SortingAlgorithms.InsertionSort(arr);

            bool isSorted = true;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1]) isSorted = false;
            }

            Assert.True(isSorted);
        }

        [Fact]
        public void SelectionSortTest()
        {
            int[] arr = { 3, 5, 4, 6, 2, 7, 1, 8 };
            SortingAlgorithms.SelectionSort(arr);

            bool isSorted = true;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1]) isSorted = false;
            }

            Assert.True(isSorted);
        }

        [Fact]
        public void QuickSortTest()
        {
            int[] arr = { 3, 5, 4, 6, 2, 7, 1, 8 };
            SortingAlgorithms.QuickSort(arr, 0, arr.Length - 1);

            bool isSorted = true;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1]) isSorted = false;
            }

            Assert.True(isSorted);
        }

        [Fact]
        public void MergeSortTest()
        {
            int[] arr = { 3, 5, 4, 6, 2, 7, 1, 8 };
            SortingAlgorithms.MergeSort(arr, 0, arr.Length - 1);

            bool isSorted = true;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1]) isSorted = false;
            }

            Assert.True(isSorted);
        }

    }
}