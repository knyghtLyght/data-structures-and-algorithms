using System;
using System.Collections.Generic;

namespace Find_matches
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyKTree testTree = new MyKTree(new Node() { Value = 10 });
            testTree.Add(10, 9);
            testTree.Add(10, 12);
            testTree.Add(10, 8);
            testTree.Add(12, 13);
            testTree.Add(12, 9);
            testTree.Add(12, 19);
            testTree.Add(9, 5);
            testTree.Add(10, 9);
            testTree.Add(5, 2);

            List<Node> testList = FindMatches(testTree, 9);
            foreach (var node in testList)
            {
                Console.WriteLine(node.Value);
            }
            Console.ReadLine();

        }

        public static List<Node> FindMatches(MyKTree inputTree, int testValue)
        {
            List<Node> returnList = new List<Node>(); //init the return list
            MyQueue stepQueue = new MyQueue(inputTree.Root); // Init the traversal queue
            Node runner = inputTree.Root;
            while (stepQueue.Peek() != null) //while the queue has something in it keep going
            {
                foreach (Node child in runner.Children)
                {
                    stepQueue.Enqueue(child);
                }
                Node popped = stepQueue.Dequeue(); //Store the dequeued value to match test value
                if (popped.Value == testValue) returnList.Add(popped); //Check and add
                runner = stepQueue.Front; //Move the runner
            }
            return returnList;
        }
    }
}
