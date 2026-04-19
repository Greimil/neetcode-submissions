public class Solution {
   public List<List<int>> Permute(int[] nums)
    {
        List<List<int>> result = new List<List<int>>();

        List<int> permutation = new List<int>();

        bool[] used = new bool[nums.Length];

      

void backtracking()
{
    if (permutation.Count == nums.Length)
    {
        result.Add(new List<int>(permutation));
        return;
    }

    for (int i = 0; i < nums.Length; i++)
    {
        if (used[i]) continue;

        permutation.Add(nums[i]);
        used[i] = true;

        backtracking();

        used[i] = false;
        permutation.RemoveAt(permutation.Count - 1);
    }
}

        backtracking();
        return result;

    }

}
