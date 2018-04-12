using System;
using System.Collections.Generic;
using System.Text;

namespace find_maximum_value_binary_tree
{
    public class MyTree
    {
        public Node Root { get; set; }
        public int MaxValue { get; set; }

        public MyTree()
        {
            Root = null;
        }

        public void Add(Node add)
        {

        }

        public int FindMaxValue()
        {
            InOrderHelper(Root);
            return MaxValue;
        }

        public void InOrderHelper(Node node)
        {
            if (node.LeftChild != null)
            {
                InOrderHelper(node.LeftChild);
            }
            if (node.Value > MaxValue)
            {
                MaxValue = node.Value;
            }
            if (node.RightChild != null)
            {
                InOrderHelper(node.RightChild);
            }
        }

        public void InOrder(Node node)
        {
            if (node.LeftChild != null)
            {
                InOrder(node.LeftChild);
            }
            Console.WriteLine(node.Value);
            if (node.RightChild != null)
            {
                InOrder(node.RightChild);
            }
        }

        public void PreOrder(Node node)
        {
            Console.WriteLine(node.Value);
            if (node.LeftChild != null)
            {
                InOrder(node.LeftChild);
            }
            if (node.RightChild != null)
            {
                InOrder(node.RightChild);
            }
        }

        public void PostOrder(Node node)
        {
            if (node.LeftChild != null)
            {
                InOrder(node.LeftChild);
            }
            if (node.RightChild != null)
            {
                InOrder(node.RightChild);
            }
            Console.WriteLine(node.Value);
        }
    }
}
