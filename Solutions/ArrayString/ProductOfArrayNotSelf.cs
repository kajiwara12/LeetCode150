using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    public class ProductOfArrayNotSelf
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];
            int beginning = 1;
            int end = 1;

            for (int i = 0; i < nums.Length; i++) 
            {
                result[i] = beginning;
                beginning *= nums[i];
            
            }
            for (int j = nums.Length - 1; j >= 0; j--)
            {
                result[j] *= end;
                end *= nums[j];
            }
            return result;
        }
    }
}
