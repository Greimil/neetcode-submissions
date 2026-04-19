public class Solution {
    public bool CanPartition(int[] nums)
    {
        int sumTotal = 0;

        foreach (int num in nums)
        {
            sumTotal += num;
        }

        if (sumTotal % 2 != 0) return false;

        int target = sumTotal / 2;

        Dictionary<(int, int), bool> memo = new Dictionary<(int, int), bool>();

        bool dfs(int idx, int currSum)
        {
            if (memo.ContainsKey((idx, currSum))) return memo[(idx, currSum)];

            if (currSum == target) return true;

            if (idx >= nums.Length || currSum > target) return false;


            memo[(idx, currSum)] = dfs(idx + 1, currSum + nums[idx]) || dfs(idx + 1, currSum);


            return memo[(idx, currSum)];

        }


        return dfs(0, 0);

    }

}
