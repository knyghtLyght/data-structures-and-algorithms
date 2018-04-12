using System;
using Xunit;
using BreadthFirstTraversal;
using static BreadthFirstTraversal.Program;

namespace Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("5 3 7 1 8 4 9 ", 3)]
        [InlineData("5 10 7 1 8 4 9 ", 10)]
        [InlineData("5 80 7 1 8 4 9 ", 80)]
        public void CanTraverse(string expected, int testValue)
        {
            //Arrange
            MyTree testTree = new MyTree()
            {
                Root = new Node() //Root Level
                {
                    Value = 5,
                    LeftChild = new Node() //Row 1
                    {
                        Value = testValue,
                        LeftChild = new Node() //Row 2
                        {
                            Value = 1
                        },
                        RightChild = new Node() //Row 2
                        {
                            Value = 8
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
                            Value = 9
                        }
                    }
                }
            };
            //Assert
            Assert.Equal(expected, BreadthFirst(testTree));
        }
    }
}
