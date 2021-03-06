using System;
using Xunit;
using QuickSortImp;
using static QuickSortImp.Program;

namespace QuickSortTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 10, 548, 63, 21, 987, 2 }, new int[] { 2, 10, 21, 63, 548, 987 })]
        [InlineData(new int[] { 987, 15, 3, 984651385, 357, 55 }, new int[] { 3, 15, 55, 357, 987, 984651385 })]
        [InlineData(new int[] { 10, 20, 30, 4, 5, 100 }, new int[] { 4, 5, 10, 20, 30, 100 })]
        public void CanSort(int[] testArray, int[] resultArray)
        {
            QuickSort(testArray, 0, testArray.Length - 1);
            Assert.Equal(resultArray, testArray);
        }
    }
}
