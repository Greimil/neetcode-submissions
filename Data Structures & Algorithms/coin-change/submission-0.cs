public class Solution {
    public int CoinChange(int[] coins, int amount)
    {
        Dictionary<int, int> memo = new Dictionary<int, int>();


        int dfs(int target)
        {
            if (target == 0) return 0;

            if (memo.ContainsKey(target)) return memo[target];


            int minCoins = int.MaxValue;



            foreach (var coin in coins)
            {

                if (coin <= target)
                {
                    int res = dfs(target - coin);

                    if (res != -1)
                    {
                        minCoins = Math.Min(minCoins, 1 + res);

                    }

                }



            }


            memo[target] = minCoins == int.MaxValue ? -1 : minCoins;

            return memo[target];
        }


        return dfs(amount);

    }

}
