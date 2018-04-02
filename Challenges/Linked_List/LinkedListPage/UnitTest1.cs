using System;
using Xunit;
using Linked_List;
using static Linked_List.Program;

namespace LinkedListPage
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(4, 4)]
        public void CanReturnValue(int input, int expected)
        {
            LinkedList testList = new LinkedList();
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);

            Assert.Equal(expected, testList.Find(input).Value);
        }

        [Theory]
        [InlineData(0,"5 4 3 2 1 0 ")]
        [InlineData(9,"5 4 3 2 1 9 ")]
        [InlineData(10,"5 4 3 2 1 10 ")]
        public void CanAppend(int newValue, string expected)
        {
            LinkedList testList = new LinkedList();
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.AddToEnd(newValue);

            Assert.Equal(expected, testList.PrintToString());
        }

        [Theory]
        [InlineData(3, 0, "5 4 0 3 2 1 ")]
        [InlineData(2, 9, "5 4 3 9 2 1 ")]
        [InlineData(4, 10, "5 10 4 3 2 1 ")]
        public void CanInsertBefore(int target, int newValue, string expected)
        {
            LinkedList testList = new LinkedList();
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.InsertBefore(target, newValue);

            Assert.Equal(expected, testList.PrintToString());
        }

        [Theory]
        [InlineData(3, 0, "5 4 3 0 2 1 ")]
        [InlineData(2, 9, "5 4 3 2 9 1 ")]
        [InlineData(4, 10, "5 4 10 3 2 1 ")]
        public void CanInsertAfter(int target, int newValue, string expected)
        {
            LinkedList testList = new LinkedList();
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.InsertAfter(target, newValue);

            Assert.Equal(expected, testList.PrintToString());
        }
        [Theory]
        [InlineData(3, 3)]
        [InlineData(2, 2)]
        [InlineData(4, 4)]
        public void CanFinPosition (int target, int expected)
        {
            LinkedList testList = new LinkedList();
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);

            Assert.Equal(expected, testList.kthFromEnd(target).Value);
        }
    }
}
