using System;
using Xunit;
using binary_search;
using static binary_search.Program;

namespace binary_search_Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 1,2,3,4,5}, 3, 2)] //Check basic
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 8, -1)] //Check not found
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 5, 4)] //Check edge

        public void Test1(int[] input, int key, int expected)
        {
            Assert.Equal(expected, Search(input, key));
        }
    }
}
