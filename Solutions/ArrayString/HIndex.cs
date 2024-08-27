using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    public class HIndexx
    {
        public int HIndex(int[] citations)
        {
            //int sum = 0;
            //foreach (int i in citations) 
            //{ 
            //    sum += i;
            //}

            //return (int)Math.Floor(sum / (double)citations.Length);
            Array.Sort(citations);
            Array.Reverse(citations);
            for (int i = 0; i < citations.Length; i++)
            {
                if (citations[i] <= i)
                {
                    return i;
                }
            }
            return citations.Length;
        }
    }
}
