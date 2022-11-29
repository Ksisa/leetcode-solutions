
using System;

namespace Leetcode_harness.Pangram
{
    public class Solution
    {
        public int CountElements(int[] arr)
        {
            var set = new HashSet<int>(arr);
            int count = 0;
            foreach(int n in arr)
            {
                if(set.Contains(n + 1))
                {
                    count++;
                }
            }

            return count;
        }

        public IList<IList<int>> FindWinners(int[][] matches)
        {
            // key : loss
            var losses = new Dictionary<int, int>();
            foreach (int[] match in matches)
            {
                // Add winner
                if (!losses.ContainsKey(match[0]))
                {
                    losses.Add(match[0], 0);
                }

                // Add loss
                if (losses.ContainsKey(match[1]))
                {
                    losses[match[1]]++;
                }
                else
                {
                    losses.Add(match[1], 1);
                }

                
            }

            var result = new int[2][];

            result[0] = losses.Where(loss => loss.Value == 0).Select(e => e.Key).ToArray();
            result[1] = losses.Where(loss => loss.Value == 1).Select(e => e.Key).ToArray();
            Array.Sort(result[0]);
            Array.Sort(result[1]);

            return result;
        }

        public int LargestUniqueNumber(int[] nums)
        {
            var count = new Dictionary<int, int>();
            foreach(int num in nums)
            {
                if (count.ContainsKey(num))
                {
                    count[num]++;
                }
                else
                {
                    count[num] = 1;
                }
                
            }

            var values = count.Where(e => e.Value == 1).Select(e => e.Key);
            if(values.Count() == 0)
            {
                return -1;
            }
            else
            {
                return values.Max();
            }
        }

        public int MaxNumberOfBalloons(string text)
        {
            var charCount = new Dictionary<char, int>();
            foreach(char c in text)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            int baloonCount = 0;

            try
            {
                while (charCount['b'] >= 1 && charCount['a'] >= 1 && charCount['l'] >= 2 && charCount['o'] >= 2 && charCount['n'] >= 1)
                {
                    baloonCount++; charCount['b']--; charCount['a']--; charCount['l']--; charCount['l']--; charCount['o']--; charCount['o']--; charCount['n']--;
                }

                return baloonCount;
            }
            catch (KeyNotFoundException)
            {
                return 0;
            }
        }
    }
}
