using System;
using Xunit;
using PrintLevelOrder;

namespace PrintLevelTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1)]
        [InlineData(-1)]
        [InlineData(20)]
        public void CanPrintLevels(int testValue)
        {
            //Arrange
            MyKTree testTree = new MyKTree(new Node() { Value = 10 });
            testTree.Add(10, 9);
            testTree.Add(10, 12);
            testTree.Add(10, 8);
            testTree.Add(12, testValue);
            testTree.Add(12, 15);
            testTree.Add(12, 19);
            testTree.Add(9, 5);
            testTree.Add(10, 9);
            testTree.Add(5, 2);

            //Assert
            Assert.Equal($"10 \n9 12 8 9 \n5 {testValue} 15 19 \n2 ",
                PrintLevelOrder.Program.PrintLevelOrder(testTree));
        }
    }
}
