using System;

namespace TaskService
{
    static public class ArrayTasks
    {
        //https://leetcode.com/problems/remove-duplicates-from-sorted-array/
        static public int RemoveDuplicatesSortedArray(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int i = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }

            return i + 1;
        }

        //https://leetcode.com/problems/remove-element/
        static public int RemoveElement(int[] nums, int val)
        {
            if (nums.Length == 0) return 0;

            int i = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != val)
                {
                    nums[i] = nums[j];
                    i++;
                }
            }

            return i;
        }

        //https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/
        static public int RemoveDuplicatesfromSortedArrayMoreThanTwo(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int i = 0;
            int dup = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                

                if (nums[j] != nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }

            return i + 1;
        }
    }
}
