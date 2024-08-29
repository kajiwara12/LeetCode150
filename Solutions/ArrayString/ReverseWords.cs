using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ArrayString
{
    public class ReverseWord
    {
        public string ReverseWords(string s)
        {
            s = s.Trim();

            string[] words = s.Split(' ');
            Array.Reverse(words);
            return String.Join(' ', words.Where(s => s != ""));
        }
       
        
        
        public string ReverseWords2(string s)
        {
            s = s.Trim();
            Stack<string> wordStack = new();
            int start = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    if (i > start)
                    {
                        wordStack.Push(s.Substring(start, i - start));
                    }
                    start = i + 1;
                }
            }

            if (start < s.Length)
            {
                wordStack.Push(s.Substring(start));
            }

            StringBuilder reversedString = new StringBuilder();
            while (wordStack.Count > 0)
            {
                reversedString.Append(wordStack.Pop() + " ");
            }

            return reversedString.ToString().Trim();
        }
    }
}
