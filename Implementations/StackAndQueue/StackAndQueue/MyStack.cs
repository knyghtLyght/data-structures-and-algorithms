using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    public class MyStack
    {
        public Node Top { get; set; }
        public Node bottom;
        //Node[] stackindex = new Node[5];
        public MyStack(Node node)
        {
            Top = node;
            bottom = node;
        }

        public void Endqueue(Node node)
        {
            node.Next = Top;
            Top = node;
        }

        public Node Dequeue()
        {
            Node pop = Top;
            if (bottom == Top)
            {
                bottom = null;
                return Top;
            }
            if (Top == null)
            {
                throw new Exception();
            }
            Node runner = bottom;
            while (runner.Next != Top)
            {
                runner = runner.Next;
            }
            runner.Next = null;
            Top = runner;
            return pop;
        }

        public Node Peek() => Top;
    }
}
