public class Solution {
    public int MaxProfit(int[] prices)
    {
        Dictionary<(bool, int), int> cache = new Dictionary<(bool, int), int>();

        int dfs(bool buy, int idx)
        {

            int res;

            if (idx >= prices.Length) return 0;
            if (cache.ContainsKey((buy, idx))) return cache[(buy, idx)];



            if (buy)
            {
                res = Math.Max(dfs(false, idx + 1) - prices[idx], dfs(true, idx + 1));
            }
            else
            {
                res = Math.Max(prices[idx] + dfs(true, idx + 2), dfs(false, idx + 1));
            }

            cache[(buy, idx)] = res;

            return res;

        }

        return dfs(true, 0);

    }
}
