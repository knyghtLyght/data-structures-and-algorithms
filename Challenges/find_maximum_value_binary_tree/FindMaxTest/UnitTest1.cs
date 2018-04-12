using System;
using Xunit;
using find_maximum_value_binary_tree;

namespace FindMaxTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(9)]
        [InlineData(10)]
        [InlineData(12)]
        public void CanFindMax(int testMax)
        {
            //Arrange
            MyTree testTree = new MyTree()
            {
                Root = new Node() //Root Level
                {
                    Value = 5,
                    LeftChild = new Node() //Row 1
                    {
                        Value = 3,
                        LeftChild = new Node() //Row 2
                        {
                            Value = 1
                        },
                        RightChild = new Node() //Row 2
                        {
                            Value = testMax
                        }
                    },
                    RightChild = new Node() //Row 1
                    {
                        Value = 7,
                        LeftChild = new Node() //Row 2
                        {
                            Value = 4
                        },
                        RightChild = new Node() //Row 2
                        {
                            Value = 8
                        }
                    }
                }
            };
            //Act
            Assert.Equal(testMax, testTree.FindMaxValue());
        }
    }
}
