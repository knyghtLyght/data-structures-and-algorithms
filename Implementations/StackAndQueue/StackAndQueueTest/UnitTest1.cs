using System;
using Xunit;
using StackAndQueue;

namespace StackAndQueueTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanPeek()
        {
            //Arrange / Act
            MyStack testStack = new MyStack(new Node() { Value = 5 });

            //Assert
            Assert.Equal("5", testStack.Peek().Value.ToString());
        }

        [Fact]
        public void CanBuildNode()
        {
            //Arrange / Act
            Node testNode = new Node() { Value = 5 };

            //Assert
            Assert.Equal("5", testNode.Value.ToString());
        }

        [Fact]
        public void CanBuildStack()
        {
            //Arrange / Act
            MyStack testStack = new MyStack(new Node() { Value = 5 });
            testStack.Push(new Node() { Value = 8 });
            testStack.Push(new Node() { Value = 14 });
            testStack.Pop();

            //Assert
            Assert.Equal("8", testStack.Peek().Value.ToString());
        }

        [Fact]
        public void CanPop()
        {
            //Arrange / Act
            MyStack testStack = new MyStack(new Node() { Value = 5 });
            testStack.Push(new Node() { Value = 8 });

            //Assert
            Assert.Equal("8", testStack.Pop().Value.ToString());
        }

        [Fact]
        public void CanPush()
        {
            //Arrange / Act
            MyStack testStack = new MyStack(new Node() { Value = 5 });
            testStack.Push(new Node() { Value = 8 });

            //Assert
            Assert.Equal("8", testStack.Pop().Value.ToString());
        }

        [Fact]
        public void CanBuildQueue()
        {
            //Arrange / Act
            MyQueue testQueue = new MyQueue(new Node() { Value = 5 });
            testQueue.Enqueue(new Node() { Value = 8 });
            testQueue.Enqueue(new Node() { Value = 14 });
            testQueue.Dequeue();

            //Assert
            Assert.Equal("8", testQueue.Dequeue().Value.ToString());
        }

        [Fact]
        public void CanEnqueue()
        {
            //Arrange / Act
            MyQueue testQueue = new MyQueue(new Node() { Value = 5 });
            testQueue.Enqueue(new Node() { Value = 8 });
            testQueue.Enqueue(new Node() { Value = 14 });

            //Assert
            Assert.Equal("5", testQueue.Peek().Value.ToString());
        }

        [Fact]
        public void CanDequeue()
        {
            //Arrange / Act
            MyQueue testQueue = new MyQueue(new Node() { Value = 5 });
            testQueue.Enqueue(new Node() { Value = 8 });

            //Assert
            Assert.Equal("5", testQueue.Dequeue().Value.ToString());
        }
    }
}
