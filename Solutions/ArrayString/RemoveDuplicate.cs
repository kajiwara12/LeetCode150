using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    public class RemoveDuplicate
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            // List to store unique elements
            List<int> uniqueList = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                // Add the first element and all elements that are different from the previous one
                if (i == 0 || nums[i] != nums[i - 1])
                {
                    uniqueList.Add(nums[i]);
                }
            }

            // Copy the unique elements back to the original array
            for (int i = 0; i < uniqueList.Count; i++)
            {
                nums[i] = uniqueList[i];
            }
            // Return the number of unique elements
            return uniqueList.Count;
        }
    }
}
