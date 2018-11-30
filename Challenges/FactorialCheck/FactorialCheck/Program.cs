using System;

namespace FactorialCheck
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
            Console.ReadLine();
        }

        /// <summary>
        /// Calculate the factorial of a given int
        /// </summary>
        /// <param name="n"></param>
        /// <returns>The Factorial of the parameter n </returns>
        public static int Factorial(int n)
        {
            if (n < 0)
            {
                return -1;
            }
            else if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
