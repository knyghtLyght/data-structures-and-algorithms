﻿using System;

namespace BreadthFirstTraversal
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyTree testTree = new MyTree()
            {
                Root = new Node() //Root Level
                {
                    Value = 5,
                    LeftChild = new Node() //Row 1
                    {
                        Value = 3,
                        LeftChild = new Node() //Row 2
                        {
                            Value = 1
                        },
                        RightChild = new Node() //Row 2
                        {
                            Value = 8
                        }
                    },
                    RightChild = new Node() //Row 1
                    {
                        Value = 7,
                        LeftChild = new Node() //Row 2
                        {
                            Value = 4
                        },
                        RightChild = new Node() //Row 2
                        {
                            Value = 9
                        }
                    }
                }
            };

            Console.WriteLine(BreadthFirst(testTree));
            Console.ReadLine();
        }

        public static string BreadthFirst(MyTree input)
        {
            string answer = "";
            Node runner = input.Root;
            MyQueue stepQueue = new MyQueue(runner);
            while (runner != null)
            {
                if (runner.LeftChild != null)
                {
                    stepQueue.Enqueue(runner.LeftChild);
                }
                if (runner.RightChild != null)
                {
                    stepQueue.Enqueue(runner.RightChild);
                }
                answer += $"{runner.Value} ";
                runner = runner.Next;
                stepQueue.Dequeue();
            };
            return answer;
        }
    }
}
