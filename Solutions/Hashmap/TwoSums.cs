using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashmap
{
    public class TwoSums
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int,int> map = new();
            for (int i = 0; i < nums.Length; i++) 
            { 
                int pair = target - nums[i];
                if (map.ContainsKey(pair))
                {
                    return [map[pair], i];
                }
                map[nums[i]] = i;
            }
            return [];
        }
    }
}
