using System;
using System.Collections.Generic;

namespace TreeIntersection
{
    public class Program
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

            foreach (string item in Tree_Intersection(treeOne, treeTwo))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static List<string> Tree_Intersection(MyTree firstTree, MyTree secondTree)
        {
            MyHashTable stepTable = new MyHashTable();
            //Init our return list
            List<string> returnList = new List<string>();
            //Split the first tree into an array
            string[] treeOneString = firstTree.PreOrder().Split(" ");
            //Push tree one into the step table
            foreach (string item in treeOneString)
            {
                stepTable.Add(item, item);
            }
            //Split the second tree into an array
            string[] treeTwoString = secondTree.PreOrder().Split(" ");
            //Push tree two string into the return table
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
