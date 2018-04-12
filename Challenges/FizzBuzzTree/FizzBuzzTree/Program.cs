using System;

namespace FizzBuzzTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyTree testTree = new MyTree()
            {
                Root = new Node() //Root Level
                {
                    Value = "5",
                    LeftChild = new Node() //Row 1
                    {
                        Value = "3",
                        LeftChild = new Node() //Row 2
                        {
                            Value = "2"
                        },
                        RightChild = new Node() //Row 2
                        {
                            Value = "10"
                        }
                    },
                    RightChild = new Node() //Row 1
                    {
                        Value = "15",
                        LeftChild = new Node() //Row 2
                        {
                            Value = "12"
                        },
                        RightChild = new Node() //Row 2
                        {
                            Value = "11"
                        }
                    }
                }
            };

            Console.WriteLine(testTree.InOrder());
            Console.WriteLine();
            FizzTree(testTree);
            Console.WriteLine(testTree.InOrder());
            Console.ReadLine();
        }

        public static string FizzBuzz(string value)
        {
            int intVal = int.Parse(value);
            if (intVal % 3 == 0 && intVal % 5 == 0)  return "FizzBuzz";
            if (intVal % 3 == 0) return "Fizz";
            if (intVal % 5 == 0) return "Buzz";
            else return value;
        }

        public static MyTree FizzTree(MyTree input)
        {
            FBHelper(input.Root);
                return input;
        }

        public static void FBHelper(Node node)
        {
            if (node.LeftChild != null)
            {
                FBHelper(node.LeftChild);
            }
            node.Value = FizzBuzz(node.Value);
            if (node.RightChild != null)
            {
                FBHelper(node.RightChild);
            }
        }
    }
}
