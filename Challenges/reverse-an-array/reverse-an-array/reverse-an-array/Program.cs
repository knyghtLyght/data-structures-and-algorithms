using System;

namespace reverse_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[] {1, 2, 3, 4, 5};
            ReverseArray(test);
            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }
            Console.ReadLine();
        }

        static Array ReverseArray(int[] input)
        {
            int temp = 0;
            for (int i = input.Length-1; i > input.Length/2 ; i--)
            {
                temp = input[(input.Length - 1) - i];
                input[(input.Length - 1) - i] = input[i];
                input[i] = temp;
            }
            return input;
        }
    }
}