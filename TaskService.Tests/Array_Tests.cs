using System;
using TaskService;
using Xunit;

namespace TaskService.Tests
{
    public class Array_Tests
    {

        #region RemoveDuplicateSortedArray

        [Fact]
        public void RemoveDuplicatesSortedArray_TestLength3()
        {
            var nums = new int[] { 1, 1, 2 };
            var expectedNums = new int[] { 1, 2, 0 };
            var expectedReturn = 2;

            var numReturn = ArrayTasks.RemoveDuplicatesSortedArray(nums);

            Assert.Equal(expectedReturn, numReturn);

            for (int i = 0; i < expectedReturn; i++)
            {
                Assert.Equal(nums[i], expectedNums[i]);
            }

        }

        [Fact]
        public void RemoveDuplicatesSortedArray_TestLength10()
        {
            var nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var expectedNums = new int[] { 0, 1, 2, 3, 4 };
            var expectedReturn = 5;

            var numReturn = ArrayTasks.RemoveDuplicatesSortedArray(nums);

            Assert.Equal(expectedReturn, numReturn);

            for (int i = 0; i < expectedReturn; i++)
            {
                Assert.Equal(nums[i], expectedNums[i]);
            }
        }

        [Fact]
        public void RemoveDuplicatesSortedArray_TestLength0()
        {
            var nums = new int[] { };
            var expectedNums = new int[] { };
            var expectedReturn = 0;

            var numReturn = ArrayTasks.RemoveDuplicatesSortedArray(nums);

            Assert.Equal(expectedReturn, numReturn);

        }

        #endregion

        #region RemoveElement
        [Fact]
        public void RemoveElement()
        {
            var nums = new int[] { 3, 2, 2, 3 };
            var removedNumber = 3;

            var expectedNums = new int[] { 2, 2 };
            var expectedReturn = 2;

            var numReturn = ArrayTasks.RemoveElement(nums, removedNumber);

            Assert.Equal(expectedReturn, numReturn);

            for (int i = 0; i < expectedReturn; i++)
            {
                Assert.Equal(nums[i], expectedNums[i]);
            }

        }

        [Fact]
        public void RemoveElement10()
        {
            var nums = new int[] { 3, 2, 2, 3, 1, 5, 0, 3, 4, 3 };
            var removedNumber = 3;
            var expectedReturn = 6;

            var numReturn = ArrayTasks.RemoveElement(nums, removedNumber);

            Assert.Equal(expectedReturn, numReturn);

            for (int i = 0; i < expectedReturn; i++)
            {
                Assert.NotEqual(nums[i], removedNumber);
            }

        }

        [Fact]
        public void RemoveElement0()
        {
            var nums = new int[] { };
            var removedNumber = 0;
            var expectedReturn = 0;

            var numReturn = ArrayTasks.RemoveElement(nums, removedNumber);

            Assert.Equal(expectedReturn, numReturn);

            for (int i = 0; i < expectedReturn; i++)
            {
                Assert.NotEqual(nums[i], removedNumber);
            }
        }

        #endregion

        [Fact]
        public void TwoSum_Test_4()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] indexArr = ArrayTasks.TwoSum(nums, target);

            Assert.NotEqual(indexArr[0], indexArr[1]);
            Assert.Equal(nums[indexArr[0]] + nums[indexArr[1]], target);
        }

        [Fact]
        public void TwoSum_Test_2()
        {
            int[] nums = { 3, 3 };
            int target = 6;

            int[] indexArr = ArrayTasks.TwoSum(nums, target);

            Assert.NotEqual(indexArr[0], indexArr[1]);
            Assert.Equal(nums[indexArr[0]] + nums[indexArr[1]], target);
        }

        [Fact]
        public void TwoSum_Test_Zero()
        {
            int[] nums = { 0, 4, 3, 0 };
            int target = 0;

            int[] indexArr = ArrayTasks.TwoSum(nums, target);

            Assert.NotEqual(indexArr[0], indexArr[1]);
            Assert.Equal(nums[indexArr[0]] + nums[indexArr[1]], target);
        }


        [Fact]
        public void TwoSum_Test_Negative()
        {
            int[] nums = { -1, -2, -3, -4, -5 };
            int target = -8;

            int[] indexArr = ArrayTasks.TwoSum(nums, target);

            Assert.NotEqual(indexArr[0], indexArr[1]);
            Assert.Equal(nums[indexArr[0]] + nums[indexArr[1]], target);
        }



    }
}
