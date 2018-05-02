using System;

namespace RepetedWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            string test = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only";

            Console.WriteLine(CheckForDupe(test));
            Console.ReadLine();
        }

        public static string CheckForDupe(string source)
        {
            string[] sourceArray = source.Split(" "); //split out input string into an Array
            MyHashTable checkTable = new MyHashTable();
            //For every item in our array check if it exisits in the table. If it dose return that word if not add it to our table
            foreach (string word in sourceArray)
            {
                if (checkTable.Contains(word) != null) return word;
                checkTable.Add(word, word);
            }
            return null;
        }
    }
}