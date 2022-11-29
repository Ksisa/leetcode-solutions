namespace Leetcode_harness.RansomNote
{
    public class Solution
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> counts = new();

            for (char c = 'a'; c <= 'z'; c++)
            {
                counts.Add(c, 0);
            }

            foreach (char c in magazine)
            {
                counts[c]++;
            }

            foreach (char c in ransomNote)
            {
                counts[c]--;
                if (counts[c] == -1)
                {
                    return false;
                }
            }
            return true;
        }

        public int NumJewelsInStones(string jewels, string stones)
        {
            HashSet<char> jewelChars = new();
            int jewelCount = 0;

            foreach(char c in jewels)
            {
                jewelChars.Add(c);
            }

            foreach(char stone in stones)
            {
                if (jewelChars.Contains(stone))
                {
                    jewelCount++;
                }
            }

            return jewelCount;
        }

        public int LengthOfLongestSubstring(string s)
        {
            int maxLen = 0;
            int left = 0;
            int right;
            Dictionary<char, int> currCount = new();

            for(right = 0; right < s.Length; right++)
            {
                if (!currCount.ContainsKey(s[right]))
                {
                    currCount.Add(s[right], 0);
                }

                currCount[s[right]]++;

                while (currCount[s[right]] > 1)
                {
                    currCount[s[left]]--;
                    left++;
                }

                if (right - left + 1 > maxLen)
                {
                    maxLen = right - left + 1;
                }
            }

            return maxLen;
        }
    }
}