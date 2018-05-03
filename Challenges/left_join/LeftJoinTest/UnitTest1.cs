using System;
using Xunit;
using left_join;
using static left_join.Program;
using System.Collections.Generic;

namespace LeftJoinTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            MyHashTable testTableOne = new MyHashTable();
            testTableOne.Add("fond", "enamored");
            testTableOne.Add("wrath", "anger");
            testTableOne.Add("diligent", "employed");
            testTableOne.Add("outfit", "garb");
            testTableOne.Add("guide", "usher");

            MyHashTable testTableTwo = new MyHashTable();
            testTableTwo.Add("fond", "adverse");
            testTableTwo.Add("wrath", "delight");
            testTableTwo.Add("diligent", "idle");
            testTableTwo.Add("guide", "follow");
            testTableTwo.Add("flow", "jam");

            List<string> joinedList = LeftJoin(testTableOne, testTableTwo);


        }
    }
}
