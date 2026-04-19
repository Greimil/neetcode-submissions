public class Solution {
      public int Change(int amount, int[] coins)
    {
        var memo = new Dictionary<(int, int), int>();

        int dfs(int idx, int remaining)
        {
            if (remaining == 0) return 1;
            if (idx >= coins.Length) return 0;
            if (memo.ContainsKey((idx, remaining)))
                return memo[(idx, remaining)];

            int ways = 0;
            for (int i = idx; i < coins.Length; i++)
            {
                if (coins[i] <= remaining)
                {
                    ways += dfs(i, remaining - coins[i]);
                }
            }

            memo[(idx, remaining)] = ways;
            return ways;
        }

        return dfs(0, amount);
    }

}
