public class Solution {
  public List<List<int>> CombinationSum2(int[] candidates, int target)
    {
        List<List<int>> result = new();
        List<int> subset = new();
        Array.Sort(candidates);



        void backtracking(int idx, int sum)
        {
            if (sum == target)
            {
                result.Add(new List<int>(subset));
                return;
            }

            if (sum > target) return;


            for (int i = idx; i < candidates.Length; i++)
            {
                if (i > idx && candidates[i] == candidates[i - 1]) continue;

                subset.Add(candidates[i]);
                backtracking(i + 1, sum + candidates[i]);
                subset.RemoveAt(subset.Count - 1);

            }


        }

        backtracking(0, 0);

        return result;

    }
}
