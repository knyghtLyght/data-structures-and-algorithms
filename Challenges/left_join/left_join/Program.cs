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
        /// <summary>
        /// Merge two hashtables using left join logic. Keeping everything on the initial table and only adding things from the right that share a key
        /// </summary>
        /// <param name="tableOne"></param>
        /// <param name="tableTwo"></param>
        /// <returns></returns>
        public static List<string> LeftJoin(MyHashTable tableOne, MyHashTable tableTwo)
        {
            List<string> returnTable = new List<string>();
            foreach (LinkedList<Node> item in tableOne.Table)
            {
                if (item != null) // if the index is not empty
                {
                    // if their is a shared key on the second table...
                    if (tableTwo.Contains(item.First.Value.Key) != null)
                    {
                        // ... add the key and both values to a string and drop it into our return list
                        returnTable.Add($"{item.First.Value.Key} {tableOne.Contains(item.First.Value.Key)} {tableTwo.Contains(item.First.Value.Key)}");
                    }
                    // if there is no matching key on the second table just add the first tables pair
                    if (tableTwo.Contains(item.First.Value.Key) is null)
                    {
                        returnTable.Add($"{item.First.Value.Key} {item.First.Value.Value}");
                    }
                }
            }
            return returnTable;
        }
    }
}
