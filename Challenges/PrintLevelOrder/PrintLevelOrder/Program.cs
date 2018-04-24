using System;

namespace PrintLevelOrder
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
        }

        public static string PrintLevelOrder(MyKTree input)
        {
            string response = "";
            MyQueue stepQueue = new MyQueue(input.Root);
            Node runner = input.Root;
            int currentLevel = 0;
            int countTwo = 0;
            while (runner != null)
            {

            }
            return response;
        }
    }
}
