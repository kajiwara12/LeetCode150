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

            string[] rows = new string[Math.Min(numRows, s.Length)];
            int currentRow = 0;
            bool goingDown = false;

            foreach (char c in s)
            {
                rows[currentRow] += c;
                if (currentRow == 0 || currentRow == numRows - 1) goingDown = !goingDown;
                currentRow += goingDown ? 1 : -1;
            }

            string result = string.Join("", rows);
            return result;
        }
    }
}
