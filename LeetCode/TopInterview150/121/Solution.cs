namespace LeetCode.TopInterview150._121;

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int maxProfit = 0;
        int relativeLowPrice = prices[0];

        for (int i = 1; i < prices.Length; i++)
        {
            if (relativeLowPrice > prices[i])
            {
                relativeLowPrice = prices[i];
                continue;
            }
            var profit = prices[i] - relativeLowPrice;
            if (profit > maxProfit)
            {
                maxProfit = profit;
            }
        }

        return maxProfit;
    }
}
