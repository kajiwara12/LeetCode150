using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    public class RemoveElement
    {
        public int RemoveElements(int[] nums, int val)
        {
            int result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[result] = nums[i];
                    result++;
                }
            }
            return result;
        }
    }
}
