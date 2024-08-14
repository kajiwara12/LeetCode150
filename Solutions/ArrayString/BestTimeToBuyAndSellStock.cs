namespace ArrayString
{
    public class BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int lowDay = 2147483647;
            int difference = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < lowDay)
                {
                    lowDay = prices[i];
                }
                else
                {
                    difference = Math.Max(difference, prices[i] - lowDay);
                }
            }
            return difference;
        }
    }
}
