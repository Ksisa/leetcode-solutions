using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_harness
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int _val, ListNode? _next = null)
        {
            val = _val;
            next = _next;
        }

        public static ListNode GenerateNodes(int[] values)
        {
            ListNode head = new(values[0]);
            ListNode curr = head;
            for (int i = 1; i < values.Length; i++)
            {
                curr.next = new ListNode(values[i]);
                curr = curr.next;
            }

            return head;
        }
    }
}
