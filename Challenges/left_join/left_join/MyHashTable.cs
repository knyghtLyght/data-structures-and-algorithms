using System;
using System.Collections.Generic;
using System.Text;

namespace left_join
{
    public class MyHashTable
    {
        public LinkedList<Node>[] Table;
        private int primeFactor = 599;

        public MyHashTable()
        {
            Table = new LinkedList<Node>[1024]; //Init our table on instantiation
        }

        public int GetHash(string key)
        {
            int hash = 0; //Set our starting hash

            foreach (char item in key) hash += item; //Convert the string into an int

            hash = hash * primeFactor % Table.Length; //Hash it

            return hash;
        }

        public void Add(string key, string value)
        {
            Node newEntry = new Node() { Value = value, Key = key }; //Store both key and value to ref later
            key = key.ToLower(); //Normalize the key
            int index = GetHash(key); //get our index to put the value into
            if (Table[index] == null)
            {
                Table[index] = new LinkedList<Node>();
                Table[index].AddFirst(newEntry);
            }
            else Table[index].AddFirst(newEntry);
        }

        public string Contains(string key)
        {
            key = key.ToLower();
            int index = GetHash(key);
            if (Table[index] == null) return null;
            foreach (Node node in Table[index])
            {
                if (node.Key.ToLower() == key) return node.Value;
            }

            return null; //If we hashed out to something but it doesn't contain our key
        }
    }
}
