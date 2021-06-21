using Xunit;

namespace TaskService.Tests
{
    public class String_Tests
    {
        
        [Theory]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("LVIII", 58)]
        [InlineData("DCXXI", 621)]
        [InlineData("MCMXCIV", 1994)]
        public void RomanToInt_Test(string value, int expected)
        {
            var result = StringTasks.RomanToInt(value);
            Assert.Equal(expected, result);
        }
    }
}