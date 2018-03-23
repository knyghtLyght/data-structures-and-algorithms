using System;

namespace largest_product_array
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] test2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            //int[][] jagged = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 } };
            int result = LargestProduct(test2D);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static int LargestProduct(int[,] input)
        {
            int largest = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (i < input.Length-1)
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
