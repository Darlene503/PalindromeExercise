using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("level", true)]
        [InlineData("civic", true)]
        [InlineData("Scoobie", false)]
        public void PalindromeTest(string word, bool expected)
        {
            //Arr
            var wordSmith = new WordSmith();

            //Act
            var actual = wordSmith.IsAPalindrome(word);

            //Asst
            Assert.Equal(expected, actual);
        }
    }
}
