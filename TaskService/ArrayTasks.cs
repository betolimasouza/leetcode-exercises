using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskService
{
    static public class ArrayTasks
    {
        
        static public int RemoveDuplicatesSortedArray(int[] nums)
        {
            //https://leetcode.com/problems/remove-duplicates-from-sorted-array/

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

        
        static public int RemoveElement(int[] nums, int val)
        {
            //https://leetcode.com/problems/remove-element/

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


        static public int[] TwoSum(int[] nums, int target)
        {
            //https://leetcode.com/problems/two-sum/
            var indexArr = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        indexArr[0] = i;
                        indexArr[1] = j;
                    }
                }
            }
            return indexArr;

        }
    }
}
