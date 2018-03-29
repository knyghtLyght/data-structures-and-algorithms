using System;
using Xunit;
using shift_array;
using static shift_array.Program;

namespace ShiftArrayTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(8, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 8, 3, 4, 5 })]
        [InlineData(7, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 7, 3, 4, 5 })]
        [InlineData(9, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 9, 3, 4, 5 })]

        public void CanInsert(int newValue, int[] input, int[] expected)
        {
            Assert.Equal(expected, ShiftArray(input, newValue));
        }
    }
}
