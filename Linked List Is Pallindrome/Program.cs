namespace Leetcode_harness
{

    
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Console.WriteLine(solution.IsPallindrome(ListNode.GenerateNodes(new int[] { 1, 1, 2, 1})));
        }
    }
}