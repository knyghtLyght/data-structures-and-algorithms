using System;
using Xunit;
using FizzBuzzTree;
using static FizzBuzzTree.Program;

namespace FizzBuzzTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(" 2 Fizz Buzz Buzz Fizz FizzBuzz 11", "5")]
        [InlineData(" 2 Fizz Buzz Fizz Fizz FizzBuzz 11", "3")]
        [InlineData(" 2 Fizz Buzz FizzBuzz Fizz FizzBuzz 11", "15")]
        public void CanFIzzBuzz(string expected, string testValue)
        {
            //Arrange
            MyTree testTree = new MyTree()
            {
                Root = new Node() //Root Level
                {
                    Value = testValue,
                    LeftChild = new Node() //Row 1
                    {
                        Value = "3",
                        LeftChild = new Node() //Row 2
                        {
                            Value = "2"
                        },
                        RightChild = new Node() //Row 2
                        {
                            Value = "10"
                        }
                    },
                    RightChild = new Node() //Row 1
                    {
                        Value = "15",
                        LeftChild = new Node() //Row 2
                        {
                            Value = "12"
                        },
                        RightChild = new Node() //Row 2
                        {
                            Value = "11"
                        }
                    }
                }
            };
            //Act
            FizzTree(testTree);
            //Assert
            Assert.Equal(expected, testTree.InOrder());
        }
    }
}
