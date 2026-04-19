public class Solution {
     public List<List<int>> SubsetsWithDup(int[] nums)
    {
        List<List<int>> result = new List<List<int>>();

        List<int> subset = new List<int>();

        Array.Sort(nums);



        void backtracking(int idx)
        {

            if (idx == nums.Length)
            {
                result.Add(new List<int>(subset));
                return;


            }


            subset.Add(nums[idx]);
            backtracking(idx + 1);
            subset.RemoveAt(subset.Count - 1);

            while (idx + 1 < nums.Length && nums[idx] == nums[idx + 1]) idx++;


            backtracking(idx + 1);



        }

        backtracking(0);
        return result;

    }


}
