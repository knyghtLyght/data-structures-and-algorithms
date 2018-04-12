using System;
using Xunit;
using BinaryTree;

namespace TreeTest
{
    public class UnitTest1
    {
        [Fact]
        public void NodeHasChild()
        {
            Node testNode = new Node() { Value = 5, LeftChild = new Node(), RightChild = new Node() };

            Assert.NotNull(testNode.LeftChild);
        }

        [Fact]
        public void NodeHasValue()
        {
            Node testNode = new Node() { Value = 5, LeftChild = new Node(), RightChild = new Node() };

            Assert.Equal(5, testNode.Value);
        }

        [Fact]
        public void TreeExists()
        {
            Assert.NotNull(new MyTree());
        }

        [Theory]
        [InlineData(" 1 3 8 5 4 7 9", 5)]
        [InlineData(" 1 3 8 10 4 7 9", 10)]
        [InlineData(" 1 3 8 12 4 7 9", 12)]
        public void InOrderTest(string expected, int testValue)
        {
            MyTree testTree = new MyTree()
            {
                Root = new Node() //Root Level
                {
                    Value = testValue,
                    LeftChild = new Node() //Row 1
                    {
                        Value = 3,
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
            Assert.Equal(expected, testTree.InOrder());
        }

        [Theory]
        [InlineData(" 5 3 1 8 7 4 9", 5)]
        [InlineData(" 10 3 1 8 7 4 9", 10)]
        [InlineData(" 12 3 1 8 7 4 9", 12)]
        public void PreOrderTest(string expected, int testValue)
        {
            MyTree testTree = new MyTree()
            {
                Root = new Node() //Root Level
                {
                    Value = testValue,
                    LeftChild = new Node() //Row 1
                    {
                        Value = 3,
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
            Assert.Equal(expected, testTree.PreOrder());
        }

        [Theory]
        [InlineData(" 1 8 3 4 9 7 5", 5)]
        [InlineData(" 1 8 3 4 9 7 10", 10)]
        [InlineData(" 1 8 3 4 9 7 12", 12)]
        public void PostOrderTest(string expected, int testValue)
        {
            MyTree testTree = new MyTree()
            {
                Root = new Node() //Root Level
                {
                    Value = testValue,
                    LeftChild = new Node() //Row 1
                    {
                        Value = 3,
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
            Assert.Equal(expected, testTree.PostOrder());
        }
    }
}
