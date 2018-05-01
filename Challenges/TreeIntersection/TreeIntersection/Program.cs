using System;
using System.Collections.Generic;

namespace TreeIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
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
                                Value = "125"
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
                                Value = "125"
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

            foreach (string item in TreeIntersection(treeOne, treeTwo))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static List<string> TreeIntersection(MyTree firstTree, MyTree secondTree)
        {
            MyHashTable stepTable = new MyHashTable();
            List<string> returnList = new List<string>();
            string[] treeOneString = firstTree.PreOrder().Split(" ");
            foreach (string item in treeOneString)
            {
                stepTable.Add(item, item);
            }
            string[] treeTwoString = secondTree.PreOrder().Split(" ");
            foreach (string item in treeTwoString)
            {
                if (stepTable.Contains(item) == item)
                {
                    returnList.Add(item);
                }
            }
            return returnList;
        }
    }
}
