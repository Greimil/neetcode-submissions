public class Solution {
      public int FindTargetSumWays(int[] nums, int target)
    {


        Dictionary<(int, int), int> memo = new Dictionary<(int, int), int>();


        int dfs(int idx, int total)
        {

            if (memo.ContainsKey((idx, total))) return memo[(idx, total)];

            if (idx == nums.Length)
            {
                return total == target ? 1 : 0;

            }


            memo[(idx, total)] = dfs(idx + 1, total + nums[idx]) + dfs(idx + 1, total - nums[idx]);

            return memo[(idx, total)];

        }



        return dfs(0, 0); ;

    }

}
