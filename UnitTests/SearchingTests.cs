using CommonAlgorithms;

namespace UnitTests
{
    public class SearchingTests
    {

        [Fact]
        public void LinearSearchTest()
        {
            int[] arr = { 2, 4, 8, 16, 32, 64, 128, 256, 512};

            Assert.Equal(2, SearchingAlgorithms.LinearSearch(arr, 8));
        }

        [Fact]
        public void BinarySearchTest()
        {
            int[] arr = { 2, 4, 8, 16, 32, 64, 128, 256, 512 };

            Assert.Equal(2, SearchingAlgorithms.BinarySearch(arr, 8));
        }

        [Fact]
        public void InterpolationSearchTest()
        {
            int[] arr = { 2, 4, 8, 16, 32, 64, 128, 256, 512 };

            Assert.Equal(2, SearchingAlgorithms.InterpolationSearch(arr, 8));
        }
    }
}
