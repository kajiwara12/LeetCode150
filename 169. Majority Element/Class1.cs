using System.Collections.Immutable;

namespace _169._Majority_Element
{
    public class Class1
    {
            public int MajorityElement(int[] nums)
            {
                int stored = 0;
                int count = 0;

                foreach (int num in nums)
                {
                    if (count == 0)
                    {
                        stored = num;
                        count = 1;
                    }
                    else if (num == stored)
                    {
                        count++;
                    }
                    else
                    {
                        count--;
                    }
                }

                return stored;
            }
        }
}
