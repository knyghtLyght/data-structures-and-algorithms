using System;

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

            Console.WriteLine(testTable.Contains("Dinner"));
            Console.ReadLine();
        }
    }
}
