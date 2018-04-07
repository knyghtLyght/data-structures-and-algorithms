using System;
using Xunit;
using BinaryTree;

namespace TreeTest
{
    public class UnitTest1
    {
        [Fact]
        public void NodeHasChild()
        {
            Node testNode = new Node() { Value = 5, LeftChild = new Node(), RightChild = new Node() };

            Assert.NotNull(testNode.LeftChild);
        }

        [Fact]
        public void NodeHasValue()
        {
            Node testNode = new Node() { Value = 5, LeftChild = new Node(), RightChild = new Node() };

            Assert.Equal(5, testNode.Value);
        }

        [Fact]
        public void TreeExists()
        {
            Assert.NotNull(new MyTree());
        }
    }
}
