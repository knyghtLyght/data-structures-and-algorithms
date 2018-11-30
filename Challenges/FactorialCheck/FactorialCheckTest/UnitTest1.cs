using System;
using Xunit;
using static FactorialCheck.Program;

namespace FactorialCheckTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(3,6)]
        [InlineData(6,720)]
        [InlineData(10,3628800)]
        public void CorrectFactorial(int testvalue, int expectedValue)
        {
            Assert.Equal(expectedValue, (Factorial(testvalue)));
        }
    }
}
