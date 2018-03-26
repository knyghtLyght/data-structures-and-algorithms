using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List
{
    class LinkedList
    {

        // The list is initially empty.
        private Node head = null;

        // Add a node at the beginning of the list with t as its data value.
        public void AddNode(LinkedList t)
        {
            Node newNode = new Node();
            newNode.Next = head;
            newNode.Value = 0;
            head = newNode;
        }
    }
}
