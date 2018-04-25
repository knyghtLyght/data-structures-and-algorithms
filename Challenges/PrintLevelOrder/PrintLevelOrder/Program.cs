using System;

namespace PrintLevelOrder
{
    public class Program
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

            Console.WriteLine(PrintLevelOrder(testTree));
            Console.ReadLine();
        }

        public static string PrintLevelOrder(MyKTree input)
        {
            string response = "";
            MyQueue stepQueue = new MyQueue(input.Root); //Setup traversal queue
            Node runner = input.Root;
            int currentLevel = 1; //current level length
            int childCount = 0; //level length accumulator
            while (runner != null) //Loop as long as there is something in the queue
            {
                childCount = 0; //Reset accumulator
                for (int i = 0; i < currentLevel; i++) //Run through all nodes in the level
                {
                    if (runner.Children != null)
                    {
                        //Add all node children to the traversal queue
                        foreach (var child in runner.Children)
                        {
                            stepQueue.Enqueue(child); 
                            childCount++;
                        }
                    }
                    response += $"{stepQueue.Dequeue().Value} "; //Append response string
                    runner = stepQueue.Front; //Move runner
                }
                if (runner != null) //If we are at the end no need to continue
                {
                    response += "\n"; //Add new line at the end of a level
                    currentLevel = childCount; //Set next level length
                }
            }
            return response;
        }
    }
}
