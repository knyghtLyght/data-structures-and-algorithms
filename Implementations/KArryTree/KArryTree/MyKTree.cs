using System;
using System.Collections.Generic;
using System.Text;

namespace KArryTree
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
            MyQueue stepQueue = new MyQueue(Root); // Init the traversal queue
            Node runner = Root;
            string response = "";
            while (stepQueue.Peek() != null) //while the queue has something in it keep going
            {
                foreach (Node child in runner.Children)
                {
                    stepQueue.Enqueue(child);
                }
                response += $"{stepQueue.Dequeue().Value} "; //Append the response string
                runner = stepQueue.Front; //Move the runner
            }
            return response;
        }

        public Node Find(int targetNodeValue)
        {
            MyQueue stepQueue = new MyQueue(Root); //Init traversal queue
            Node runner = Root;
            while (stepQueue.Peek() != null) //While there is somethign in the queue keep going
            {
                //If we found what we want break
                if (runner.Value == targetNodeValue)
                {
                    return runner;
                }
                //Add the node children to the traversal queue
                if (runner.Children != null)
                {
                    foreach (Node child in runner.Children)
                    {
                        stepQueue.Enqueue(child);
                    }
                }
                stepQueue.Dequeue(); //drop the last checked node
                runner = stepQueue.Front; //Move the runner
            }
            return new Node();
        }

        public void Add(int targetNodeValue, int valueToAdd)
        {
            //find our node with the desired value and add to its children
            Find(targetNodeValue).Children.Add(new Node() { Value = valueToAdd });
        }
    }
}