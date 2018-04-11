using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthFirstTraversal
{
    class MyTree
    {
        public static Node Root { get; set; }

        public MyTree()
        {
            Root = null;
        }

        public void Add(Node add)
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
