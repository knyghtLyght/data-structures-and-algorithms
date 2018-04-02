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
    }
}
