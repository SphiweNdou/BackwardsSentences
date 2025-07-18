using BackwardsSentences;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace BackwardsSentences.Tests
{
    public class BackwardsSentencesTests
    {
        [Theory]
        [InlineData("this is a test", "test a is this")]
        [InlineData("foobar", "foobar")]
        [InlineData("all your base", "base your all")]
        [InlineData("  a  b   c  ", "c b a")]
        [InlineData("", "")]
        public void ReverseSentence_wordOrder_reversedSentenced(string input, string expected)
        {
            Assert.Equal(expected, ReverseSentenceHelper.ReverseSentence(input));
        }

        [Fact]
        public void ReverseSentence_NullInput_EmptyString()
        {
            string? input = null;
            var result = ReverseSentenceHelper.ReverseSentence(input ?? string.Empty);
            Assert.Equal(string.Empty, result);
        }
    }
}