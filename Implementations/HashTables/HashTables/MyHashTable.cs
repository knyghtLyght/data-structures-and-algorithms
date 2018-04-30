using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables
{
    public class MyHashTable
    {
        private Node[] Table;
        private int primeFactor = 599;

        public MyHashTable()
        {
            Table = new Node[1024]; //Init our table on instantiation
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
            Node newEntry = new Node() { Value = value , Key = key }; //Store both key and value to ref later
            key = key.ToLower(); //Normalize the key
            int index = GetHash(key); //get our index to put the value into
            if (Table[index] != null) //If something is there add to the linked list
            {
                Table[index].Next = newEntry;
            }
            if (Table[index] == null) //If empty just add the node
            {
                Table[index] = newEntry;
            }
        }

        public string Contains(string key)
        {
            key = key.ToLower();
            Node target = Table[GetHash(key)]; //Find out linked list by it's hash
            while (target.Key.ToLower() != key) //If we don't have the right key look to the next list item
            {
                target = target.Next;
            }
            return target.Value; //Return the value
        }
    }
}
