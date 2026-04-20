public class Solution {
    public void SortColors(int[] nums) {
        int l = 0;
        int m = 0;
        int r = nums.Length - 1;

        while (m <= r) {
            int num = nums[m];
            int temp = 0;

            if (num == 0) {
                temp = nums[l];
                nums[l] = num;
                nums[m] = temp;
                m++;
                l++;
            } else if (num == 2) {
                temp = nums[r];
                nums[r] = num;
                nums[m] = temp;
                r--;
            } else {
                m++;
            }
        }
    }
}