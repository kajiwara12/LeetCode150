using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    public class MaxProfitt
    {
        public int MaxProfit(int[] prices)
        {
            int result = 0;
            for (int i = 0; i < prices.Length; i++) 
            { 
                
                if (prices[i] - prices[i + 1] < 0)
                {
                    result += Math.Abs(prices[i] - prices[i + 1]);
                }
            }
            return result;
        }
    }
}
