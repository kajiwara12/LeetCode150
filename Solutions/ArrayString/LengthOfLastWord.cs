using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    public class LengthOfLastWordd
    {
        public int LengthOfLastWord(string s)
        {
            int result = 0;
            s = s.Trim();
            result=s.Length-s.LastIndexOf(" ")-1;
            return result;
        }
    }
}
