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
            Table = new LinkedList<Node>[1024]; //Init our table on instantiation
        }

        /// <summary>
        /// Takes in a value and hashes it into the key to be used as the index in the hash table
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int GetHash(string key)
        {
            int hash = 0; //Set our starting hash

            foreach (char item in key) hash += item; //Convert the string into an int

            hash = hash * primeFactor % Table.Length; //Hash it

            return hash;
        }

        /// <summary>
        /// The add function that will call our hash function and insert our value
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(string key, string value)
        {
            Node newEntry = new Node() { Value = value , Key = key }; //Store both key and value to ref later
            key = key.ToLower(); //Normalize the key
            int index = GetHash(key); //get our index to put the value into
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
