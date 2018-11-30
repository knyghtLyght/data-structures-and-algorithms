using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List
{
    public class LinkedList
    {
        // The list is initially empty.
        private Node head = null;

        // Add a node at the beginning of the list with the contents of value as its value.
        public void Add(int value)
        {
            Node newNode = new Node(); //Make the new Node
            newNode.Next = head; // Set the nodes reference for the first in the list
            newNode.Value = value; // Set the new nodes data
            head = newNode; //set the new node as the head or fist in the list
        }

        public Node Find(int target)
        {
            Node step = head;
            while (step.Next != null)
            {
                if (step.Value == target)
                {
                    return step;
                }
                step = step.Next;
            }
            return head; //If not in the list set to the head node
        }

        public void AddToEnd(int newValue)
        {
            Node runner = head;
            Node newNode = new Node();
            while (runner.Next != null)
            {
                runner = runner.Next;
            }
            runner.Next = newNode;
            newNode.Next = null;
            newNode.Value = newValue;
        }

        public void InsertBefore(int targetValue, int newValue)
        {
            Node runner = head;
            while (runner.Next != null)
            {
                if (runner.Next.Value == targetValue)
                {
                    Node preNode = Find(runner.Value);
                    Node newNode = new Node();
                    newNode.Next = preNode.Next;
                    preNode.Next = newNode;
                    newNode.Value = newValue;
                    break;
                }
                runner = runner.Next;
            }
        }

        public void InsertAfter(int targetValue, int newValue)
        {
            Node newNode = new Node();
            newNode.Value = newValue;
            Node targetNode = Find(targetValue);
            newNode.Next = targetNode.Next;
            targetNode.Next = newNode;
        }

        public string PrintToString()
        {
            StringBuilder sb = new StringBuilder("");

            Node step = head;
            while (step.Next != null)
            {
                sb.Append($"{step.Value} ");
                step = step.Next;
            }
            sb.Append($"{step.Value} ");
            return sb.ToString();
        }
        // Helper length method to make kthFromEnd shorter
        public int ListLength()
        {
            Node runner = new Node();
            runner.Next = head;
            int length = 0;
            while (runner.Next != null)
            {
                length++;
                runner = runner.Next;
            }
            return length;
        }

        public Node kthFromEnd(int k)
        {
            Node runner = new Node();
            runner.Next = head;
            for (int i = 0; i <= ListLength() - k; i++)
            {
                runner = runner.Next;
            }
            return runner;
        }

        public Node MergeLists(LinkedList inputList)
        {
            Node runnerOne = head;
            Node runnerTwo = inputList.head;
            int limit = inputList.ListLength();
            if (ListLength() < inputList.ListLength())
            {
                limit = ListLength();
            }
            for(int i = 0; i < limit; i++)
            {
                InsertAfter(runnerOne.Value, runnerTwo.Value);
                if (i == limit)
                {
                    break;
                }
                runnerOne = runnerOne.Next.Next;
                runnerTwo = runnerTwo.Next;
            }
            return head;
        }

        public bool hasLoop()
        {
            int lemgth = ListLength();
            bool hasLoop = false;
            Node runner = new Node();
            runner.Next = head;
            for (int i = 0; i < lemgth; i++)
            {
                if (runner.Next == null) hasLoop = true;
            }
            return hasLoop;
        }
    }
}
