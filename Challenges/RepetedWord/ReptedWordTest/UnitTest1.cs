using System;
using Xunit;
using RepetedWord;
using static RepetedWord.Program;

namespace ReptedWordTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Once upon a time, there was a brave princess who", "a")]
        [InlineData("We started off green, very green, but the figth would take it's toll", "green,")]
        [InlineData("It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only", "it")]
        public void CanFindDupe(string testValue, string dupe)
        {
            Assert.Equal(dupe, CheckForDupe(testValue));
        }
    }
}
