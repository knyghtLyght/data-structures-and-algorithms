using System;
using Xunit;
using FizzBuzzTree;
using static FizzBuzzTree.Program;

namespace FizzTreeTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("5", "Buzz")]
        [InlineData("3", "Fizz")]
        [InlineData("15", "FizzBuzz")]
        [InlineData("0", "0")]
        public void CanFizzBuzz(string value, string expected)
        {
            Assert.Equal(expected, FizzBuzz(value));
        }
    }
}
