using System;

namespace KArryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            MyKTree testTree = new MyKTree(new Node() { Value = 10 });
            testTree.Add(10, 9);
            testTree.Add(10, 12);
            testTree.Add(10, 8);
            testTree.Add(12, 13);
            testTree.Add(12, 15);
            testTree.Add(12, 19);
            testTree.Add(9, 5);
            testTree.Add(10, 9);
            testTree.Add(5, 2);
            Console.WriteLine(testTree.BreadthFirst());
            Console.ReadLine();
        }
    }
}