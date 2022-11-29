using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_harness.RunningSum
{
    public class Solution
    {
        public int MinStartValue(int[] nums)
        {
            {
                int[] sums = new int[nums.Length];
                sums[0] = nums[0];
                for (int i = 1; i < nums.Length; i++)
                {
                    sums[i] = nums[i] + sums[i - 1];
                }

                int min = sums.Min();
                if (min > 0)
                {
                    return 1;
                }

                return Math.Abs(min - 1);
            }
        }
    }
}