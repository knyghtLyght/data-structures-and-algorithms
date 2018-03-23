using System;
using Xunit;
using largest_product_array;
using static largest_product_array.Program;

namespace largest_product_array_Test
{
    public class UnitTest1
    {
        [Fact]    
        public void CanReturnInt1()
        {
            Assert.Equal(56, LargestProduct(new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } }));
        }

        [Fact]
        public void CanReturnInt2()
        {
            Assert.Equal(40, LargestProduct(new int[,] { { 4, 2 }, { 8, 4 }, { 2, 6 }, { 5, 8 } }));
        }

        [Fact]
        public void CanReturnInt3()
        {
            Assert.Equal(49, LargestProduct(new int[,] { { 1, 6 }, { 3, 3 }, { 5, 9 }, { 7, 7 } }));
        }
    }
}
