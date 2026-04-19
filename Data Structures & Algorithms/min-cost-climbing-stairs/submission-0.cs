public class Solution {
      public int MinCostClimbingStairs(int[] cost)
    {
        Dictionary<int, int> memo = new Dictionary<int, int>();

        int dfs(int i)
        {
            if (i >= cost.Length) return 0;

            if (memo.ContainsKey(i)) return memo[i];

            memo[i] = cost[i] + Math.Min(dfs(i + 1), dfs(i + 2));


            return memo[i];

        }    

        return Math.Min(dfs(0), dfs(1));


    }   
}
