using System;
using System.Collections.Generic;
using System.Text;

namespace TowersOfHanoi
{
    public class MyStack
    {
        public Node Top { get; set; }
        public string Name { get; set; } //Stack name for printing stack ID

        public MyStack(Node node)
        {
            Top = node; //Set Top ref to inital node
        }
        public MyStack() //default constructor
        {

        }

        public void Push(Node node)
        {
            if (Top == null)
            {
                node.Next = null;
            }
            else
            {
                node.Next = Top; //Give new Node ref pointing down
            }
            Top = node; //New node becomes top
        }

        public Node Pop()
        {
            if (Top == null)
            {
                throw new Exception();
            }
            else
            {
                Node pop = Top; //Grab return ref
                Top = Top.Next; //Set the next in line to top
                return pop;
            }
        }

        public Node Peek() => Top;

        public void PrintStack()
        {
            Node runner = Top;
            while (runner.Next != null)
            {
                Console.WriteLine(runner.Value);
                runner = runner.Next;
            }
            Console.WriteLine(runner.Value);
        }
    }
}
