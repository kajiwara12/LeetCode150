
using System;

namespace LeetCode150
{
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            //Pointers
            int i = m - 1;  
            int j = n - 1;  
            int k = m + n - 1;  

           
            for (int p = k; p >= 0; p--)
            {
                if (j < 0) // No more elements in nums2 to merge
                {
                    break;
                }

                if (i >= 0 && nums1[i] > nums2[j])
                {
                    nums1[p] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[p] = nums2[j];
                    j--;
                }
            }
        }
    }
}