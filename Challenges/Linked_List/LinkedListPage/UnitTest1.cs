using System;
using Xunit;
using Linked_List;
using static Linked_List.Program;

namespace LinkedListPage
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 1)]
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

            Assert.Equal(expected, testList.Find(input).Value);
        }

    }
}
