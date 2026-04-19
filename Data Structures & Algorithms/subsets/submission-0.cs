public class Solution {
    public List<List<int>> Subsets(int[] nums)
    {
        List<List<int>> result = new();

        List<int> subSet = new();


        void backtracking(int idx)
        {
            //Base case
            if (idx == nums.Length)
            {
                result.Add(new List<int>(subSet));
                return;
            }

            //Take the option
            subSet.Add(nums[idx]);
            backtracking(idx + 1);

            // No take the option
            subSet.RemoveAt(subSet.Count - 1);
            backtracking(idx + 1);

        }
        backtracking(0);
        return result;

    }
}
