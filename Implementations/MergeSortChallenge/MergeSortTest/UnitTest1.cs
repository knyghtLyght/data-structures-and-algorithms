using System;
using Xunit;
using MergeSortChallenge;
using static MergeSortChallenge.Program;

namespace MergeSortTest
{
    public class UnitTest1
    {
        [Fact]
        public void SortTestOne()
        {
            //Arrange
            int[] testArray = new int[5] { 4, 3, 5, 2, 6 };

            Assert.Equal(new int[5] { 2, 3, 4, 5, 6 }, MergeSort(testArray));
        }

        [Fact]
        public void SortTestTwo()
        {
            //Arrange
            int[] testArray = new int[5] { 4, 1, 5, 2, 6 };

            Assert.Equal(new int[5] { 1, 2, 4, 5, 6 }, MergeSort(testArray));
        }

        [Fact]
        public void SortTestThree()
        {
            //Arrange
            int[] testArray = new int[5] { 4, 3, 5, 2, 7 };

            Assert.Equal(new int[5] { 2, 3, 4, 5, 7 }, MergeSort(testArray));
        }
    }
}
