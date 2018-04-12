using System;

namespace find_maximum_value_binary_tree
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine(testTree.FindMaxValue());
            Console.ReadLine();
        }
    }
}
