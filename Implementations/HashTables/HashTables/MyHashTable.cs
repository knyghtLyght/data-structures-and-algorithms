using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables
{
    public class MyHashTable
    {
        private LinkedList<Node>[] Table;
        private int primeFactor = 599;

        /// <summary>
        /// Constructor that establishes the base table
        /// </summary>
        public MyHashTable()
        {
            //Init our table on instantiation
            Table = new LinkedList<Node>[1024];
        }

        /// <summary>
        /// Takes in a value and hashes it into the key to be used as the index in the hash table
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int GetHash(string key)
        {
            //Set our starting hash
            int hash = 0;
            //Convert the string into an int
            foreach (char item in key) hash += item;
            //Hash it
            hash = hash * primeFactor % Table.Length;

            return hash;
        }

        /// <summary>
        /// The add function that will call our hash function and insert our value
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(string key, string value)
        {
            //Store both key and value to ref later
            Node newEntry = new Node() { Value = value , Key = key };
            //Normalize the key
            key = key.ToLower();
            //get our index to put the value into
            int index = GetHash(key); 
            if (Table[index] == null)
            {
                Table[index] = new LinkedList<Node>();
                Table[index].AddFirst(newEntry);
            }
            else Table[index].AddFirst(newEntry);
        }

        /// <summary>
        /// Lookup function. Returns a list of the values located at a given key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public List<string> Contains(string key)
        {
            key = key.ToLower();
            int index = GetHash(key);
            if (Table[index] == null) return null;
            List<string> ansList = new List<string>();
            foreach (Node node in Table[index])
            {
                if (node.Key.ToLower() == key) ansList.Add(node.Value);
            }
            return ansList;
        }
    }
}
