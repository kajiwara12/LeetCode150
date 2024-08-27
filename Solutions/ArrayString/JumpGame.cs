using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    public class JumpGame
    {
        public bool CanJump(int[] nums)
        {
            int currentPosition = 0;

            while (nums[currentPosition] != 0) 
            { 
                int range = nums[currentPosition];
                 var movementList =  nums[currentPosition..(currentPosition + range)];
                currentPosition += movementList.Select((x, y) => x + y).Max();
                if (currentPosition >= nums.Length) { return true; }
            }
            return false;
        }
    }
}
