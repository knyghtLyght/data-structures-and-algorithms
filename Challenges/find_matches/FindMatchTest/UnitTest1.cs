using System;
using Xunit;
using Find_matches;

namespace FindMatchTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(9)]
        [InlineData(1)]
        [InlineData(-1)]
        public void CanFindMatches(int testValue)
        {
            //Arrange
            MyKTree testTree = new MyKTree(new Node() { Value = 10 });
            testTree.Add(10, testValue);
            testTree.Add(10, 12);
            testTree.Add(10, 8);
            testTree.Add(12, 13);
            testTree.Add(12, testValue);
            testTree.Add(12, 19);
            testTree.Add(testValue, 5);
            testTree.Add(10, testValue);
            testTree.Add(5, 2);

            //Assert
            Assert.Equal(3, Find_matches.Program.FindMatches(testTree, testValue).Count);
        }
    }
}
