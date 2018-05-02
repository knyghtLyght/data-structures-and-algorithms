using System;
using Xunit;
using TreeIntersection;
using static TreeIntersection.Program;

namespace TreeINtersectionTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("900")]
        [InlineData("345")]
        [InlineData("1")]
        public void CanCompareTrees(string testValue)
        {
            //Arrange
            MyTree treeOne = new MyTree()
            {
                Root = new Node() //Root Level
                {
                    Value = "150",
                    LeftChild = new Node() //Row 1
                    {
                        Value = "100",
                        LeftChild = new Node() //Row 2
                        {
                            Value = "75"
                        },
                        RightChild = new Node() //Row 2
                        {
                            Value = "160",
                            LeftChild = new Node() //Row 3
                            {
                                Value = testValue
                            },
                            RightChild = new Node() //Row 3
                            {
                                Value = "175"
                            }
                        }
                    },
                    RightChild = new Node() //Row 1
                    {
                        Value = "250",
                        LeftChild = new Node() //Row 2
                        {
                            Value = "200"
                        },
                        RightChild = new Node() //Row 2
                        {
                            Value = "350",
                            LeftChild = new Node() //Row 3
                            {
                                Value = "300"
                            },
                            RightChild = new Node() //Row 3
                            {
                                Value = "500"
                            }
                        }
                    }
                }
            };

            MyTree treeTwo = new MyTree()
            {
                Root = new Node() //Root Level
                {
                    Value = "150",
                    LeftChild = new Node() //Row 1
                    {
                        Value = "100",
                        LeftChild = new Node() //Row 2
                        {
                            Value = "15"
                        },
                        RightChild = new Node() //Row 2
                        {
                            Value = "160",
                            LeftChild = new Node() //Row 3
                            {
                                Value = testValue
                            },
                            RightChild = new Node() //Row 3
                            {
                                Value = "175"
                            }
                        }
                    },
                    RightChild = new Node() //Row 1
                    {
                        Value = "600",
                        LeftChild = new Node() //Row 2
                        {
                            Value = "200"
                        },
                        RightChild = new Node() //Row 2
                        {
                            Value = "350",
                            LeftChild = new Node() //Row 3
                            {
                                Value = "4"
                            },
                            RightChild = new Node() //Row 3
                            {
                                Value = "500"
                            }
                        }
                    }
                }
            };

            Assert.Contains(testValue, Tree_Intersection(treeOne, treeTwo));
        }
    }
}
