using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    public class RemovDupe2
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int i = 1, count = 1;

            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] == nums[j - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count <= 2)
                {
                    nums[i] = nums[j];
                    i++;
                }
            }

            return i;
        }

        public int RemoveDuplicates2(int[] nums)
        {
            if (nums.Length <= 2) return nums.Length;

            int i = 2;

            for (int j = 2; j < nums.Length; j++)
            {
                if (nums[j] != nums[i - 2])
                {
                    nums[i] = nums[j];
                    i++;
                }
            }

            return i;
        }

    }
}
