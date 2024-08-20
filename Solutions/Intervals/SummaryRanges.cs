namespace Intervals
{
    public class SummaryRanges
    {
        public IList<string> SummaryRange(int[] nums)
        {
            List<string> result = new List<string>();

            if (nums.Length == 0) return result;

            int start = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == nums.Length - 1 || nums[i + 1] != nums[i])
                {
                    if (start == nums[i])
                    {
                        result.Add(start.ToString());
                    }
                    else
                    {
                        result.Add(start + "->" + nums[i]);
                    }
                    if (i != nums.Length - 1)
                    {
                        start = nums[i + 1];
                    }
                }
            }

            return result;
        }
    }
}
