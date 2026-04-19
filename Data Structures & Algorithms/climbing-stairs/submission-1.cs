public class Solution {
    public int ClimbStairs(int n)
    {

        Dictionary<int, int> memo = new Dictionary<int, int>();

        int dfs(int n, int i)
        {
            if (i >= n) return i == n ? 1 : 0;

            if (memo.ContainsKey(i))  return memo[i];


            memo[i] = dfs(n, i + 1) +  dfs(n, i + 2);


            return memo[i];  

        }

        return dfs(n, 0);

    }

}
