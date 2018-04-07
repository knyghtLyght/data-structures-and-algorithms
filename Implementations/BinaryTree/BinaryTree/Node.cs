using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class Node
    {
        public int Value { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }

        public void Add(Node node)
        {

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

        public void PostOrder(Node node)
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
    }
}
