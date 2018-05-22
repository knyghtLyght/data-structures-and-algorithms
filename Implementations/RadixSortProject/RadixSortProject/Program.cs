using System;
using System.Collections.Generic;

namespace RadixSortProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] testArray = new int[6] { 10, 548, 63, 21, 987, 2 };
            foreach (int item in testArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            int[] results = RadixSort(testArray);
            foreach (int item in results)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Sorting method that returns a sorted array of int
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] RadixSort(int[] array)
        {
            //Completion flag used to exit the sorting loop
            bool isFinished = false;
            //Property keeping track of the significant digit
            int digitPosition = 0;

            //Establishes the sorting buckets
            List<Queue<int>> buckets = new List<Queue<int>>();
            for (int i = 0; i < 10; i++)
            {
                Queue<int> q = new Queue<int>();
                buckets.Add(q);
            }

            //Sorting loop
            while (!isFinished)
            {
                //Exit condition
                isFinished = true;
                //Loop through the array and sort each value into the correct bucket based on the significant figure
                foreach (int value in array)
                {
                    //Find our current bucket
                    int bucketKey = (value / (int)Math.Pow(10, digitPosition)) % 10;
                    //Set our flag based on the significant figure
                    if (bucketKey > 0)
                    {
                        isFinished = false;
                    }
                    //place our value into the correct bucket
                    buckets[bucketKey].Enqueue(value);
                }

                int i = 0;
                //Pull our values out and place them in the new sorted order
                foreach (Queue<int> bucket in buckets)
                {
                    while (bucket.Count > 0)
                    {
                        array[i] = bucket.Dequeue();
                        i++;
                    }
                }
                //Move to the next significant figure
                digitPosition++;
            }
            return array;
        }
    }
}
