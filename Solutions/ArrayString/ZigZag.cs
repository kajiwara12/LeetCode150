using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    public class ZigZag
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1) return s;
            StringBuilder result = new();
            int cycle = 2 * numRows - 2;
            for (int r = 0; r < numRows; r++)
            {
                for (int j = r; j < s.Length; j += cycle)
                {
                    result.Append(s[j]);
                    int secondChar = j + cycle - 2 * r;
                    if (r != 0 && r != numRows - 1 && secondChar < s.Length)
                    {
                        result.Append(s[secondChar]);
                    }
                }
            }
            return result.ToString();
        }
    }
}
