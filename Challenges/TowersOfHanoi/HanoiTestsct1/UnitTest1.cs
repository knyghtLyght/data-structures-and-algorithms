using System;
using Xunit;
using TowersOfHanoi;

namespace HanoiTestsct1
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
    }
}
