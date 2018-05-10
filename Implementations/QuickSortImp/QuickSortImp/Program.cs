using System;

namespace QuickSortImp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[10] { 4, 3, 5, 2, 6, 1, 7, 9, 8, 10 };
            foreach (int item in testArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            QuickSort(testArray, 0, testArray.Length-1);
            foreach (int item in testArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static void QuickSort(int[] input, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(input, start, end); //Split and sort

                QuickSort(input, start, i - 1); //Run the sort on the first half
                QuickSort(input, i + 1, end); //Run the sort on the second hlaf
            }
        }

        public static int Partition(int[] input, int start, int end)
        {
            int temp;
            int right = input[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (input[j] <= right)
                {
                    i++;
                    temp = input[i];
                    input[i] = input[j];
                    input[j] = temp;
                }
            }

            temp = input[i + 1];
            input[i + 1] = input[end];
            input[end] = temp;
            return i + 1;
        }
    }
}
