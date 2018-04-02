using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    public class MyStack
    {
        public Node Top { get; set; }

        public MyStack(Node node)
        {
            Top = node; //Set Top ref to inital node
        }

        public void Push(Node node)
        {
            node.Next = Top; //Give new Node ref pointing down
            Top = node; //New node becomes top
        }

        public Node Pop()
        {
            Node pop = Top; //Grab return ref
            Top = Top.Next; //Set the next in line to top
            return pop;
        }

        public Node Peek() => Top;
    }
}
