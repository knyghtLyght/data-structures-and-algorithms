using System;

namespace binary_search
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(Search(test, 3));
            Console.ReadLine();
        }

        public static int Search(int[] input, int key)
        {
            for (int i = 0; i <= input.Length-1; i++)
            {
                if (input[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
