public class Solution {
     public int LengthOfLIS(int[] nums)
{
    Dictionary<(int, int), int> memo = new();

    int dfs(int idx, int prevIndex)
    {
        if (idx >= nums.Length) return 0;

        if (memo.ContainsKey((idx, prevIndex)))
            return memo[(idx, prevIndex)];

        
        int opt2 = dfs(idx + 1, prevIndex);

        
        int opt1 = 0;
        if (prevIndex == -1 || nums[idx] > nums[prevIndex])
        {
            opt1 = 1 + dfs(idx + 1, idx);
        }

        memo[(idx, prevIndex)] = Math.Max(opt1, opt2);
        return memo[(idx, prevIndex)];
    }

    return dfs(0, -1);
}
}
