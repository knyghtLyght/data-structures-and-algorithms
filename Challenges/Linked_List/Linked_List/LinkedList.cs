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
            newNode.Next = head; // Set the nodes referance for the first in the list
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
            Node newNode = head;
            while (newNode.Next != null)
            {
                newNode = newNode.Next;
            }
            newNode.Next = null;
            newNode.Value = newValue;
        }

        public void InsertBefore(int targetValue, int newValue)
        {
            Node newNode = head;
            while (newNode.Next != null)
            {
                if (newNode.Next.Value == targetValue)
                {
                    Node preNode = Find(newNode.Value);
                    newNode.Next = preNode.Next.Next;
                    preNode.Next = newNode;
                    newNode.Value = newValue;
                }
            }
        }

        public void InsertAfter(int targetValue, int newValue)
        {
            Node newNode = new Node();
            Node targetNode = Find(targetValue);
            newNode.Next = targetNode.Next;
            targetNode.Next = newNode;
        }

        public void PrintToConsole()
        {
            Node step = head;
            while (step.Next != null)
            {
                Console.WriteLine(step.Value);
            }
        }
    }
}
