using System;

namespace BinaryTree
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

            Console.WriteLine(testTree.InOrder());
            Console.WriteLine();
            Console.WriteLine(testTree.PreOrder());
            Console.WriteLine();
            Console.WriteLine(testTree.PostOrder());
            Console.ReadLine();
        }
    }
}
