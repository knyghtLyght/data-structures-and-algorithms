using System;
using System.Collections.Generic;
using System.Text;

namespace queue_with_stacks
{
    public class StackedQueue
    {
        public static Node SeedNode { get; set; }

        public StackedQueue( int value)
        {
            SeedNode.Value = value;
        }

        MyStack inputStack = new MyStack(SeedNode);
        MyStack outputStack = new MyStack(SeedNode);

        public void Enqueue(int value)
        {
            Node node = new Node() { Value = value };
            inputStack.Push(node);
        }

        public int Dequeue()
        {
            if (outputStack == null)
            {
                while (inputStack != null)
                {
                    outputStack.Push(inputStack.Pop());
                }
            }
            return outputStack.Pop().Value;
        }
    }
}
