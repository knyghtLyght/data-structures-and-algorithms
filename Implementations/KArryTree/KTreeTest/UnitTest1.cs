using System;
using Xunit;
using KArryTree;

namespace KTreeTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanBuildTree()
        {
            //Arrange
            MyKTree testTree = new MyKTree(new Node() { Value = 10 });

            Assert.Equal("10 ", testTree.BreadthFirst());
        }

        [Fact]
        public void CanAddToTree()
        {
            //Arrange
            MyKTree testTree = new MyKTree(new Node() { Value = 10 });
            testTree.Add(10, 9);

            Assert.Equal("10 9 ", testTree.BreadthFirst());
        }

        [Fact]
        public void BreadthFirstTest()
        {
            //Arrange
            MyKTree testTree = new MyKTree(new Node() { Value = 10 });
            testTree.Add(10, 9);
            testTree.Add(10, 12);
            testTree.Add(10, 8);
            testTree.Add(12, 13);
            testTree.Add(12, 15);
            testTree.Add(12, 19);
            testTree.Add(9, 5);
            testTree.Add(10, 9);
            testTree.Add(5, 2);

            Assert.Equal("10 9 12 8 9 5 13 15 19 2 ", testTree.BreadthFirst());
        }

        [Fact]
        public void CanFind()
        {
            //Arrange
            MyKTree testTree = new MyKTree(new Node() { Value = 10 });
            testTree.Add(10, 9);
            testTree.Add(10, 12);
            testTree.Add(10, 8);
            testTree.Add(12, 13);
            testTree.Add(12, 15);
            testTree.Add(12, 19);
            testTree.Add(9, 5);
            testTree.Add(10, 9);
            testTree.Add(5, 2);

            Assert.Equal("8", testTree.Find(8).Value.ToString());
        }
    }
}
