using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    public class MajorityElements
    {
       public int MajorityElement(int[] nums)
        {
            int stored = 0;
            int count = 0;

            foreach (int num in nums)
            {
                if (count == 0)
                {
                    stored = num;
                    count = 1;
                }
                else if (num == stored)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }

            return stored;
        }
    }
}
