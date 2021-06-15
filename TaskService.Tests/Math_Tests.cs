using Xunit;

namespace TaskService.Tests
{
    public class Math_Tests
    {
        [Theory]
        [InlineData(123, 321)]
        [InlineData(-123, -321)]
        [InlineData(1200, 21)]
        [InlineData(0, 0)]
        [InlineData(2147483647, 0)]
        public void ReverseInteger(int value, int expected)
        {
            var result = MathService.ReverseInteger(value);

            Assert.Equal(expected, result);
        }
    }
}