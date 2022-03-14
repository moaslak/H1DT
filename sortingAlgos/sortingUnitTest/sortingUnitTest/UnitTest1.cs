using Xunit;
using System;
using sortingAlgos;

namespace sortingAlgosUTest
{
    public class UnitTest1
    {
        quickSortClass quickSort = new quickSortClass();
        const int N = 10;
        [Fact]
        public void bubbleSortTest()
        {
            int[] testData = quickSort.testData(N);
            int[] input = testData;
            Array.Sort(testData);
            int[] expected = testData;

            Assert.Equal(expected, quickSort.bubbleSort(input));
        }

        [Fact]
        public void bubbleSortString()
        {
            string[] testData = { "a", "ab", "b", "1", "11", "zeb", "zz" };
            string[] expected = { "1", "11", "a", "ab", "b", "zeb", "zz" };

            Assert.Equal(expected, quickSort.bubbleSort(testData));
        }

        [Fact]
        public void quickSortTestNumneric()
        {
            int[] testData = quickSort.testData(N);
            int[] input = testData;
            Array.Sort(testData);
            int[] expected = testData;

            Assert.Equal(expected, quickSort.quickSort(input, 0, input.Length - 1));
        }
        
        
        [Fact]
        public void quickSortTestString()
        {
            //string[] testData = { "a", "aa", "b", "1", "11", "zeb", "zz" };
            //string[] expected = { "1", "11", "a", "aa", "b", "zeb", "zz" };

            string[] testData = { "aa","bb", "za", "1" };
            string[] expected = {"aa","bb", "za", "1" };

            Assert.Equal(expected, quickSort.quickSort(testData, 0, testData.Length - 1));
        }
    }
}