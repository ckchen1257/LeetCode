namespace LeetCode.TopInterview150._122;

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int accumulateProfit = 0;
        int previousPrice = prices[0];

        for (int i = 1; i < prices.Length; i++)
        {
            var profit = prices[i] - previousPrice;
            if (profit > 0)
            {
                accumulateProfit += profit;
            }
            previousPrice = prices[i];
        }
        return accumulateProfit;
    }
}
