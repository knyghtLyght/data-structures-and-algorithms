using System;
using System.Collections.Generic;
using System.Text;

namespace PrintLevelOrder
{
    public class MyKTree
    {
        public Node Root { get; set; }

        public MyKTree(Node root)
        {
            Root = root;
        }

        public string BreadthFirst()
        {
            MyQueue stepQueue = new MyQueue(Root);
            Node runner = Root;
            string response = "";
            while (stepQueue.Peek() != null)
            {
                foreach (Node child in runner.Children)
                {
                    stepQueue.Enqueue(child);
                }
                response += $"{stepQueue.Dequeue().Value} ";
                runner = stepQueue.Front;
            }
            return response;
        }

        public Node Find(int targetNodeValue)
        {
            MyQueue stepQueue = new MyQueue(Root);
            Node runner = Root;
            while (stepQueue.Peek() != null)
            {
                if (runner.Value == targetNodeValue)
                {
                    return runner;
                }
                if (runner.Children != null)
                {
                    foreach (Node child in runner.Children)
                    {
                        stepQueue.Enqueue(child);
                    }
                }
                stepQueue.Dequeue();
                runner = stepQueue.Front;
            }
            return new Node();
        }

        public void Add(int targetNodeValue, int valueToAdd)
        {
            Find(targetNodeValue).Children.Add(new Node() { Value = valueToAdd });
        }
    }
}
