﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    public class MyQueue
    {
        public Node Front { get; set; }

        //public int QueueLength()
        //{
        //    Node runner = new Node();
        //    int length = 0;
        //    do
        //    {
        //        length++;
        //    } while (runner.Next != null);
        //    return length;
        //}

        public MyQueue(Node node)
        {
            node.Next = null;
            Front = node; //Set inital node to the front
        }

        public void Enqueue(Node node)
        {
            Node runner = new Node();
            runner = Front; //Set a runner at the front running to the back
            while (runner.Next != null)
            {
                runner = runner.Next;
            }
            runner.Next = node; //Set the new node as the tail end
            node.Next = null;
        }

        public Node Dequeue()
        {
            Node pop = Front; //Grab the return ref
            Front = Front.Next; //pass the front to the next in line
            return pop;
        }

        public Node Peek() => Front;
    }
}
