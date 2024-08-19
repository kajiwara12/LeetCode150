using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashmap
{
    public class ContainsDuplicate2
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> map = new();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    int check = i - map[nums[i]];
                    if (check <= k)
                    {
                        return true;
                    }
                    else
                    {
                        map[nums[i]] = i;
                    }
                }
                else
                {
                    map.Add(nums[i], i);
                }
            }
            return false;
        }
        public bool ContainsNearbyDuplicate2(int[] nums, int k)
        {
            HashSet<int> map = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.TryGetValue(nums[i], out _))
                {
                    return true;
                }
                if (i >= k) 
                { 
                    map.Remove(nums[i-k]);
                }
                map.Add(nums[i]);
            }
            return false;

        }
    }

}
