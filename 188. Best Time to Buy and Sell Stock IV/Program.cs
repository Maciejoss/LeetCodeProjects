public class Solution
{
    public int MaxProfit(int k, int[] prices)
    {
        if (prices.Length == 0) return 0;
        int[,] days = new int[++k, prices.Length];

        days[0, 0] = 0;
        for (int l = 0; l < k; l++)
        {
            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (days[l, i + 1] < days[l, i]) days[l, i + 1] = days[l, i];
                if (l < k - 1)
                    for (int j = i + 1; j < prices.Length; j++)
                    {
                        int profit = prices[j] - prices[i];
                        if (profit <= 0) continue;
                        if (days[l + 1, j] < days[l, i] + profit) days[l + 1, j] = days[l, i] + profit;
                    }
            }
        }
        return days[k - 1, prices.Length - 1];
    }
}