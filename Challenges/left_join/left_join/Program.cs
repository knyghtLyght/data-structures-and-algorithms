using System;
using System.Collections.Generic;

namespace left_join
{
    public class Program
    {
        static void Main(string[] args)
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

            foreach (var item in joinedList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public static List<string> LeftJoin(MyHashTable tableOne, MyHashTable tableTwo)
        {
            List<string> returnTable = new List<string>();
            foreach (LinkedList<Node> item in tableOne.Table)
            {
                if (item != null)
                {
                    if (tableTwo.Contains(item.First.Value.Key) != null)
                    {
                        returnTable.Add($"{item.First.Value.Key} {tableOne.Contains(item.First.Value.Key)} {tableTwo.Contains(item.First.Value.Key)}");
                    }
                    if (item != null && tableTwo.Contains(item.First.Value.Key) is null)
                    {
                        returnTable.Add($"{item.First.Value.Key} {item.First.Value.Value}");
                    }
                }
            }
            return returnTable;
        }
    }
}
