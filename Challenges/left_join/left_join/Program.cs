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
        }

        public static MyHashTable LeftJoin(MyHashTable tableOne, MyHashTable tableTwo)
        {
            List<string> returnTable = new List<string>();
            foreach (LinkedList<Node> item in tableOne.Table)
            {
                string key = item.First.Value.Key;
                if (tableTwo.Contains(key) != null)
                {
                    
                }
            }
        }
    }
}
