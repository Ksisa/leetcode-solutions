using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_harness.FixedWindowAverage
{
    public class Solution
    {

        public double GetAverage(int[] window)
        {
            int sum = 0;
            foreach (int n in window)
            {
                sum = sum + n;
            }

            return (double)sum / window.Length;
        }

        public double FindMaxAverage(int[] nums, int k)
        {

            double sum = 0;
            for (int i = 0; i < k; i++)
                sum += nums[i];
            double res = sum;
            for (int i = k; i < nums.Length; i++)
            {
                sum += nums[i] - nums[i - k];
                res = Math.Max(res, sum);
            }
            return res / k;
            
        }
    }
}