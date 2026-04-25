public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int l = 0;
        int r = 1;
        int len = nums.Length;

        while (r < len) {
            if (nums[l] != nums[r]) {
                nums[l + 1] = nums[r];
                l++;
            }

            r++;
        }

        return l + 1;
    }
}