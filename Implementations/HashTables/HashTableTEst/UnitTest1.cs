using System;
using Xunit;
using HashTables;

namespace HashTableTEst
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("test")]
        [InlineData("Anime")]
        [InlineData("Why?")]
        public void CanHash(string testValue)
        {
            //Arrange
            MyHashTable testTable = new MyHashTable();
            //Act
            int hash = testTable.GetHash(testValue);
            //Assert
            Assert.Equal(hash, testTable.GetHash(testValue));
        }

        [Theory]
        [InlineData("Breakfast", "Eggs and pulled pork")]
        [InlineData("Lunch", "Cobb Salad")]
        [InlineData("Dinner", "Pork loin")]
        public void CanAdd(string key, string value)
        {
            //Arrange
            MyHashTable testTable = new MyHashTable();
            //Act
            testTable.Add(key, value);
            //Assert
            Assert.Equal(value, testTable.Contains(key));
        }
    }
}
