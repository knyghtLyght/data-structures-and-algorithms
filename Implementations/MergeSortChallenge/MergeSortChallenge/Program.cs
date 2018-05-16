using System;

namespace MergeSortChallenge
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
            Console.WriteLine();
            int[] result = MergeSort(testArray);

            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static int[] MergeSort(int[] input) //Base level and range setup. Also returns the complete recursion
        {
            MergeSort(input, 0, input.Length - 1); //set our bounds
            return input;
        }

        public static void MergeSort(int[] input, int low, int high) //overload to preform the actual resursion
        {
            if (low < high) //Base case and check for tiny array
            {
                int middle = (low / 2) + (high / 2); //Split our input
                MergeSort(input, low, middle);  //Pass our first new set in
                MergeSort(input, middle + 1, high); //Pass our second new set in
                Merge(input, low, middle, high); //Sort and merge the cuurent set
            }
        }

        private static void Merge(int[] input, int low, int middle, int high)
        {

            int left = low; //Set our left pointer
            int right = middle + 1; // set our right pointer
            int[] tmp = new int[(high - low) + 1]; //int our temp array
            int tmpIndex = 0; //Establish our variable that places our values. 

            while ((left <= middle) && (right <= high)) //While our pointers are not out of range
            {
                if (input[left] < input[right]) //If our left value is smaller
                {
                    tmp[tmpIndex] = input[left]; //grab our target
                    left = left + 1; //Move the left pointer down the array to the right
                }
                else
                {
                    tmp[tmpIndex] = input[right]; //grab our target
                    right = right + 1; //move the right pointer down the array to the right
                }
                tmpIndex = tmpIndex + 1; //Move the value one to the right
            }

            if (left <= middle) //If we have not reached the middle
            {
                while (left <= middle)
                {
                    tmp[tmpIndex] = input[left]; //move the target
                    left = left + 1; //move our pointer up
                    tmpIndex = tmpIndex + 1; //move up our temp array too
                }
            }

            if (right <= high) //If we have not reached the end
            {
                while (right <= high)
                {
                    tmp[tmpIndex] = input[right]; //Move our target
                    right = right + 1; //move our pointer up
                    tmpIndex = tmpIndex + 1; //Move up our temp array
                }
            }

            for (int i = 0; i < tmp.Length; i++) //For everyhting in our temp array
            {
                input[low + i] = tmp[i]; //Place our values
            }
        }
    }
}
