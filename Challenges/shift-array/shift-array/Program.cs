using System;

namespace shift_array
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[] { 1, 2, 3, 4, 5 };
            int insert = 8;
            int[] newArray = ShiftArray(test, insert);
            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }
            Console.ReadLine();
        }

        public static int[] ShiftArray (int[] input, int valueToAdd)
        {
            int startLength = input.Length;
            int[] returnArray = new int[startLength + 1];
            int midPoint = startLength / 2;
            for (int i = 0; i <= startLength-1; i++)
            {
                if (i < midPoint)
                {
                    returnArray[i] = input[i];
                }
                if (i == midPoint)
                {
                    returnArray[i] = valueToAdd;
                    returnArray[i+1] = input[i];
                }
                if (i > midPoint)
                {
                    returnArray[i + 1] = input[i];
                }
            }
            return returnArray;
        }
    }
}
