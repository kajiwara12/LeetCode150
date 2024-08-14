using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace ArrayString
{
    public class LongestPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            int index = 0;
            var sb = new StringBuilder();
            string shortest = strs[0];
            foreach (string str in strs)
            {
                if (str.Length < shortest.Length) 
                { 
                    shortest = str;
                }
            }
            while (index < shortest.Length) 
            {
                char currentchar = shortest[index];
                foreach (string str in strs) 
                { 
                    if (str[index] != currentchar)
                    {
                        return sb.ToString();
                    }
                }
                sb.Append(currentchar);
                index++; 
            }
            return sb.ToString();
        }
    }
}
