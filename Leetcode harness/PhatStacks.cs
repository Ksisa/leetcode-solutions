using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_harness.PhatStacks
{
    public class Solution
    {
        public string SimplifyPath(string path)
        {
            var components = path.Split('/');
            var result = new Stack<string>();

            for (int i = 0; i < components.Length; i++)
            {
                switch (components[i])
                {
                    case (".."):
                        if (result.Count > 0)
                        {
                            result.Pop();
                        }
                        break;
                    case ".":
                    case "":
                        break;
                    default:
                        result.Push(components[i]);
                        break;

                }
            }

            return new StringBuilder().Append("/").Append(string.Join('/', result.Reverse().ToArray())).ToString();
        }
        public string MakeGood(string s)
        {
            var result = new Stack<char>();
            result.Push(s[0]);
            for (int i = 1; i < s.Length; i++)
            {
                result.TryPeek(out char left);
                char right = s[i];
                if (
                    Char.ToLower(left) == Char.ToLower(right) 
                 && Char.IsUpper(left) != Char.IsUpper(right)
                 )
                {
                    result.Pop();
                }
                else
                {
                    result.Push(s[i]);
                }
            }
            return String.Join(String.Empty, result.Reverse());
        }
    }
}
