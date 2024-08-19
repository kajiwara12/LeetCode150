using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashmap
{
    public class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {   
            if(s.Length != t.Length) return false;

            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                 if (keyValuePairs.ContainsKey(s[i])) keyValuePairs[s[i]]++;
                 else keyValuePairs[s[i]]=1;
            }
            foreach (char c in t)
            {   if (!keyValuePairs.ContainsKey(c)) return false;
                if (keyValuePairs.ContainsKey(c)) keyValuePairs[c]--;
                if (keyValuePairs[c] == 0) { keyValuePairs.Remove(c); }
            }
        return keyValuePairs.Count == 0;
        }
    }
}
