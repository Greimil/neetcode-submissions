public class Solution {
      public int Rob(int[] nums)
    {

       

        Dictionary<int, int> memo = new Dictionary<int, int>();

        int dfs(int i)
        {
            if (i >= nums.Length) return 0;

            if (memo.ContainsKey(i)) return memo[i];

            memo[i] = Math.Max(nums[i] + dfs(i + 2), dfs(i + 1));
        

            return memo[i];
        }



        return dfs(0);

    }
}
