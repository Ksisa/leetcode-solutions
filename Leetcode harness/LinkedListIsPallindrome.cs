using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_harness.LinkedListIsPallindrome
{
    public class Solution
    {
        public bool IsPallindrome(ListNode head) 
        {
            Stack<int> stack = new();
            ListNode curr = head;
            while (curr != null)
            {
                stack.Push(curr.val);
                curr = curr.next;
            }

            curr = head;
            int len = stack.Count;
            for (int i = 0; i < len / 2; i++)
            {
                if (curr.val != stack.Pop())
                {
                    return false;
                }
                curr = curr.next;
            }

            return true;
        }
    }
}