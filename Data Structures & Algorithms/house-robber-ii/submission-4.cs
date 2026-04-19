public class Solution {
    public int Rob(int[] nums)
{
    if (nums.Length == 1) return nums[0];
    if (nums.Length == 2) return Math.Max(nums[0], nums[1]);

    int robLine(int start, int end)
    {
        Dictionary<int, int> memo = new Dictionary<int, int>();

        int dfs(int i)
        {
            if (i > end) return 0;

            if (memo.ContainsKey(i)) return memo[i];

            int option1 = nums[i] + dfs(i + 2);
            int option2 = dfs(i + 1);

            memo[i] = Math.Max(option1, option2);
            return memo[i];
        }

        return dfs(start);
    }

    return Math.Max(robLine(0, nums.Length - 2), robLine(1, nums.Length - 1));
}
}
