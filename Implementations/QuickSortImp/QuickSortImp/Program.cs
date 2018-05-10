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
            QuickSort(testArray, 0, testArray.Length);
            foreach (int item in testArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static void QuickSort(int[] input, int startIndex, int endIndex)
        {
            int left = startIndex, right = endIndex;
            int pivot = input[(startIndex + endIndex) / 2];

            while (left < right)
            {
                while ((input[right] >= pivot) && (left < right))
                {
                    right--;
                }

                if (left != right)
                {
                    input[left] = input[right];
                    left++;
                }

                while ((input[left] <= pivot) && (left < right))
                {
                    left++;
                }

                if (left != right)
                {
                    input[right] = input[left];
                    right--;
                }
            }

            input[left] = pivot;
            pivot = left;

            if (left < pivot)
            {
                QuickSort(input, left, pivot - 1);
            }

            if (right > pivot)
            {
                QuickSort(input, pivot + 1, right);
            }
    }
    }
}
