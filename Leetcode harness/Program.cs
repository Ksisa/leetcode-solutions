using Leetcode_harness.PhatStacks;

namespace Leetcode_harness
{

    
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            //Console.WriteLine(solution.LongestOnes(new int[] { 1,1,1,0,0,0,1,1,1,1,0  }, 2));
            //Console.WriteLine(solution.ReverseBetween(ListNode.GenerateNodes(new int[] {1,2,3,4,5}), 2, 4));
            Console.WriteLine(solution.MakeGood("abBAcC"));
        }
    }
}