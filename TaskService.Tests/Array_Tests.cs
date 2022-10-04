using Xunit;

namespace TaskService.Tests
{
    public class Array_Tests
    {

        [Theory]
        [InlineData(new int[] { 1, 1, 2 }, new int[] { 1, 2, 0 }, 2)]
        [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, new int[] { 0, 1, 2, 3, 4 }, 5)]
        [InlineData(new int[] {  }, new int[] { }, 0)]
        public void RemoveDuplicatesSortedArray(int[] nums, int[] expectedNums, int expectedReturn)
        {
            var numReturn = ArrayTasks.RemoveDuplicatesSortedArray(nums);

            Assert.Equal(expectedReturn, numReturn);

            for (int i = 0; i < expectedReturn; i++)
            {
                Assert.Equal(nums[i], expectedNums[i]);
            }

        }

        [Theory]
        [InlineData(new int[] { 3, 2, 2, 3 }, 3, new int[] { 2, 2 })]
        [InlineData(new int[] { 3, 2, 2, 3, 1, 5, 0, 3, 4, 3 }, 3, new int[] { 2, 2, 1, 5, 0, 4 })]
        [InlineData(new int[] { }, 0, new int[] { })]
        public void RemoveElement(int[] nums, int removedNumber, int[] expectedNums)
        {
            var numReturn = ArrayTasks.RemoveElement(nums, removedNumber);
            int expectedReturn = expectedNums.Length;
            Assert.Equal(expectedReturn, numReturn);

            for (int i = 0; i < expectedReturn; i++)
            {
                Assert.Equal(nums[i], expectedNums[i]);
            }
        }

        [Theory]
        [InlineData(new int[] {3,3}, 6)]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9)]
        [InlineData(new int[] { 0, 4, 3, 0 }, 0)]
        [InlineData(new int[] { -1, -2, -3, -4, -5 }, -8)]
        public void TwoSum_Test(int[] array, int result)
        {
            int[] indexArr = ArrayTasks.TwoSum(array, result);

            Assert.NotEqual(indexArr[0], indexArr[1]);
            Assert.Equal(array[indexArr[0]] + array[indexArr[1]], result);
        }

        [Theory]
        [InlineData(new int[] {1, 1, 0, 1, 1, 1 }, 3)]
        [InlineData(new int[] {1, 0, 1, 1, 0, 1 }, 2)]
        public void MaxConsecutiveOnes(int[] nums, int expectedResult)
        {
            var result = ArrayTasks.MaxConsecutiveOnes(nums);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(new int [] {1, 2, 3, 4 }, new int[] {1, 3, 6, 10 })]
        [InlineData(new int [] {1, 1, 1, 1, 1 }, new int[] {1, 2, 3, 4, 5 })]
        [InlineData(new int [] {3, 1, 2, 10, 1 }, new int[] {3, 4, 6, 16, 17 })]
        public void RunningSumOfOneDimensionArray(int[] nums, int[] expectedResult)
        {
            var result = ArrayTasks.RunningSumOfOneDimensionArray(nums);
            Assert.Equal(expectedResult, result);
        }
    }
}
