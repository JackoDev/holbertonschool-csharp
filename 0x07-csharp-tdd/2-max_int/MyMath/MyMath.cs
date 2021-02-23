using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary> A class operations</summary>
    public class Operations
    {
        /// <summary> Returns the max num inside a list</summary>
        public static int Max(List<int> nums)
        {

            if (nums == null || nums.Count <= 0)
                return 0;
            int i = 1;
            int max = nums[0];
            while (i < nums.Count) 
            {
                if (nums[i] > max) 
                {
                    max = nums[i];
                }
                i++;
            }
            return max;
        }
    }
}
