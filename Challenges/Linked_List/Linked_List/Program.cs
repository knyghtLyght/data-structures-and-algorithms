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

        }
    }
}
