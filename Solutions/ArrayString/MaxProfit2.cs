﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    internal class MaxProfit2
    {
        public int MaxProfit(int[] prices)
        {
            int result = 0;
            for (int i = 1; i < prices.Length; i++)
            {

                if (prices[i] > prices[i - 1])
                {
                    result += prices[i] - prices[i - 1];
                }
            }
            return result;
        }
    }
}
