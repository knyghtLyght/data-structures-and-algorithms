using System;

namespace FizzBuzzTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        public string FizzBuzz(string value)
        {
            int intVal = int.Parse(value);
            if (intVal % 3 == 0 && intVal % 5 == 0)  return "FizzBUzz";
            if (intVal % 3 == 0) return "Fizz";
            if (intVal % 5 == 0) return "Buzz";
            else return value;
        }

        public MyTree FizzTree(MyTree input)
        {
            FBHelper(input.Root);
                return input;
        }

        public void FBHelper(Node node)
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
