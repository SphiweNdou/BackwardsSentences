using BackwardsSentences;

namespace BackwardsSentences.Tests
{
    public class BackwardsSentencesTests
    {
        [Theory]
        [InlineData("this is a test", "test a is this")]
        [InlineData("foobar", "foobar")]
        [InlineData("all your base", "base your all")]
        public void ReverseSentence_wordOrder_reversedSentenced(string input, string expected)
        {
            Assert.Equal(expected, ReverseSentenceHelper.ReverseSentence(input));
        }
    }
}