using System;
using System.Collections.Generic;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            MyHashTable testTable = new MyHashTable();
            testTable.Add("Lunch", "Salad");
            testTable.Add("Breakfast", "Eggs and pulled pork");
            testTable.Add("Dinner", "Pork Loin");
            testTable.Add("Dinner", "Pizza");


            List<string> results = testTable.Contains("Dinner");
            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
