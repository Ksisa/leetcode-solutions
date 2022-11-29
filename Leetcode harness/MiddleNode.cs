using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_harness.MiddleNode
{
    public class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            ListNode current = head;
            while (current != null && current.next != null)
            {
                if (current.next.val == current.val)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }
            return head;
        }

        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            if (head.next == null || left == right)
            {
                return head;
            }

            ListNode leftSentinel = null;
            ListNode rightSentinel = null;
            ListNode prev = null;
            ListNode curr = head;
            int i = 1;

            while (curr != null && i < left)
            {
                prev = curr;
                curr = curr.next;
                i++;
            }

            leftSentinel = prev;
            rightSentinel = curr;
            prev = curr;
            curr = curr.next;
            i++;



            while (curr != null && i <= right)
            {
                ListNode nextNode = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nextNode;
                i++;
            }

            if(leftSentinel != null)
            {
                leftSentinel.next = prev;
            }
            else
            {
                head = prev;
            }
            
            rightSentinel.next = curr;
            

            return head;
        }

    }
}