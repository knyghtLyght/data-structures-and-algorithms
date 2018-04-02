using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    public class MyQueue
    {
        public Node Front { get; set; }

        public int QueueLength()
        {
            Node runner = new Node();
            int length = 0;
            do
            {
                length++;
            } while (runner.Next != null);
            return length;
        }

        public MyQueue(Node node)
        {
            node.Next = null;
            Front = node;
        }

        public void Push(Node node)
        {
            Node runner = new Node();
            runner = Front;
            while (runner.Next != null)
            {
                runner = runner.Next;
            }
            runner.Next = node;
            node.Next = null;
        }

        public Node Pop()
        {
            Node pop = Front;
            Front = Front.Next;
            return pop;
        }

        public Node Peek() => Front;
    }
}
