public class Solution {
    public bool hasDuplicate(int[] nums) {
        var hashset = new HashSet<int>();

        foreach(var num in nums) {
            hashset.Add(num);
        }

        return hashset.Count != nums.Length;

    }
}