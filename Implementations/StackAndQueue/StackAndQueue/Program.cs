using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack testStack = new MyStack(new Node() { Value = 5 });
            testStack.Push(new Node() { Value = 8 });
            testStack.Push(new Node() { Value = 14 });

            Console.WriteLine(testStack.Peek().Value);
            Console.ReadLine();
            Console.WriteLine(testStack.Pop().Value);
            Console.WriteLine(testStack.Peek().Value);
            Console.ReadLine();

            MyQueue testQueue = new MyQueue(new Node() { Value = 5 });
            testQueue.Enqueue(new Node() { Value = 8 });
            testQueue.Enqueue(new Node() { Value = 14 });

            Console.WriteLine(testQueue.Peek().Value);
            Console.ReadLine();
            Console.WriteLine(testQueue.Dequeue().Value);
            Console.WriteLine(testQueue.Peek().Value);
            Console.ReadLine();
        }
    }
}
