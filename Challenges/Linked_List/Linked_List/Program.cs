using System;

namespace Linked_List
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList testList = new LinkedList();
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            Console.WriteLine(testList.Find(3).Value);
            Console.ReadLine();
            Console.WriteLine(testList.PrintToString()); 
            Console.WriteLine();
            testList.AddToEnd(0);
            Console.WriteLine(testList.PrintToString());
            Console.ReadLine();
            testList.InsertBefore(3, 10);
            Console.WriteLine(testList.PrintToString());
            Console.ReadLine();
            testList.InsertAfter(3, 12);
            Console.WriteLine(testList.PrintToString());
            Console.ReadLine();
            Console.WriteLine(testList.ListLength());
            Console.ReadLine();
            Console.WriteLine(testList.kthFromEnd(3).Value);
            Console.ReadLine();
        }
    }
}
