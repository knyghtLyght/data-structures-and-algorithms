using System;

namespace InsertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[10] { 4, 3, 5, 2, 6, 1, 7, 9, 8, 10 };
            foreach (int item in testArray)
            {
                Console.WriteLine(item);
            }
            int[] ansArray = InsertionSortInt(testArray);
            foreach (int item in ansArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static int[] InsertionSortInt(int[] inputArray)
        {
            int target, insertPoint; //Set our pointer and our temp holder
            for (int i = 1; i < inputArray.Length; i++) //Set our loop that runs through the array
            {
                target = inputArray[i]; //grab our item to check
                insertPoint = i - 1; //Start looking one behind the target
                while (insertPoint >= 0 && inputArray[insertPoint] > target)
                {
                    inputArray[insertPoint + 1] = inputArray[insertPoint];
                    insertPoint--;
                }
                inputArray[insertPoint + 1] = target; //grab our next item to compare
            }
            return inputArray;
        }
    }
}
