using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingWindow
{
    public class LongestSubstring
    {
        public int LengthOfLongestSubstring(string s)
        {
            int length = 0;
            int n = s.Length;
            int left = 0;
            Dictionary<char, int> charIndexMap = new Dictionary<char, int>();
            foreach (char c in s) {
                if (charIndexMap.ContainsKey(c)) {
                    left = Math.Max(left, charIndexMap[c] + 1);
                }
                charIndexMap[c] = charIndexMap.Count;
                length = Math.Max(length, charIndexMap.Count);
            }

            return length;
        }
    }
}
