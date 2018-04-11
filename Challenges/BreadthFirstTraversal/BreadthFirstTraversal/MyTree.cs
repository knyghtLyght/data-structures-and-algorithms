using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthFirstTraversal
{
    class MyTree
    {
        public static Node Root { get; set; }
        public static int[] AddArray { get; set; }

        public MyTree()
        {
            Root = null;
        }

        public void Add(Node add)
        {
            if (Root == null)
            {
                Root = add;
                return;
            }
            PreOrder(Root);
            
        }

        public void BreadthFirst(Node runner)
        {
            runner = Root;
            MyQueue stepQueue = new MyQueue(runner);
            do
            {
                if (runner.LeftChild != null)
                {
                    stepQueue.Enqueue(runner.LeftChild);
                }
                if (runner.RightChild != null)
                {
                    stepQueue.Enqueue(runner.RightChild);
                }
                Console.WriteLine(runner.Value);
                runner = runner.Next;
                stepQueue.Dequeue();
            } while (Root.Next != null);
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
            AddArray.Add(node.Value);
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
