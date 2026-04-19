public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] res = new int[nums.Length * 2];

        int idx = 0;

        while(idx < nums.Length) {
            res[idx] = nums[idx];
            res[idx + nums.Length] = nums[idx];
            idx++;
        }


        return res;

    }
} 