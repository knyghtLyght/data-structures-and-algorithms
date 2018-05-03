using System;
using Xunit;
using left_join;
using static left_join.Program;
using System.Collections.Generic;

namespace LeftJoinTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("wrath", "anger", "delight")]
        [InlineData("common", "ubiqitus", "rare")]
        [InlineData("confident", "assured", "trepid")]
        public void CanJoinLeft(string wordOne, string wordTwo, string wordThree)
        {
            MyHashTable testTableOne = new MyHashTable();
            testTableOne.Add("fond", "enamored");
            testTableOne.Add(wordOne, wordTwo);
            testTableOne.Add("diligent", "employed");
            testTableOne.Add("outfit", "garb");
            testTableOne.Add("guide", "usher");

            MyHashTable testTableTwo = new MyHashTable();
            testTableTwo.Add("fond", "adverse");
            testTableTwo.Add(wordOne, wordThree);
            testTableTwo.Add("diligent", "idle");
            testTableTwo.Add("guide", "follow");
            testTableTwo.Add("flow", "jam");

            List<string> joinedList = LeftJoin(testTableOne, testTableTwo);

            Assert.Contains($"{wordOne} {wordTwo} {wordThree}", LeftJoin(testTableOne, testTableTwo));
        }
    }
}
