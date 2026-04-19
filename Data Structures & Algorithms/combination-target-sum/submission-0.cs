public class Solution {
   public List<List<int>> CombinationSum(int[] nums, int target)
    {
        List<List<int>> result = new();

        List<int> subsets = new();


        void backtracking(int idx, int sumSubset)
        {
            if (sumSubset == target)
            {
                result.Add(new List<int>(subsets));
                return;
            }

            if (sumSubset > target) return;


            for (int i = idx; i < nums.Length; i++)
            {
                subsets.Add(nums[i]);
                backtracking(i, sumSubset + nums[i]);
                subsets.RemoveAt(subsets.Count - 1);


            }


        }

        backtracking(0, 0);
        return result;

    }
}
