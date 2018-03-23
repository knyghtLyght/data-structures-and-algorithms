using System;

namespace largest_product_array
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] test2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            int result = LargestProduct(test2D);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static int LargestProduct(int[,] input)
        {
            int runLength = input.Length/2; //The arrays length is total not pairs so I need to cut my loop in half
            int largest = 0;
            for (int i = 0; i < runLength; i++)
            {
                if (i == runLength - 1) //The last index has only one comperision to make
                {
                    int dimOne = input[i, 0] * input[i, 1];
                    if (dimOne > largest)
                    {
                        largest = dimOne;
                    }
                }
                else
                {
                    int dimOne = input[i, 0] * input[i, 1];
                    if (dimOne > largest)
                    {
                        largest = dimOne;
                    }
                    int dimTwo = input[i, 0] * input[i + 1, 0];
                    if (dimTwo > largest)
                    {
                        largest = dimTwo;
                    }
                }
            }
            return largest;
        }
    }
}
