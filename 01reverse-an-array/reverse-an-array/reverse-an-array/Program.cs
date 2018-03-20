using System;

namespace reverse_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[] {1, 2, 3, 4, 5};
            ReverseArray(test);
        }

        static Array ReverseArray(int[] input)
        {
            int temp = 0;
            for (int i = input.Length-1; i > input.Length/2 ; i--)
            {
                temp = input[i - (input.Length - 1)];
                input[i-(input.Length - 1)] = input[i];
                input[i] = temp;
            }
            return input;
        }
    }
}
