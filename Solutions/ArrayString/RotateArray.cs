using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    public class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            int arrayLength = nums.Length;
            int[] copy = new int[k];
            
            //copy the elements we need to shift to the front
            for (int i = 0; i < k; i++) 
            {
                copy[i] = nums[arrayLength-k+i];
            }
            //shift the front elements to the back
            for (int i = arrayLength - 1; i >= k; i--)
            {
                nums[i] = nums[i - k];
            }
            //Place the copied elements at the beginning
            for (int i = 0; i < k; i++)
            {
                nums[i] = copy[i];
            }
        }
    }
}
