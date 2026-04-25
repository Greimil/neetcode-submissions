public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        k = k % n; 
        
        Reverse(nums, 0, n - 1);     
        Reverse(nums, 0, k - 1);     
        Reverse(nums, k, n - 1);    
    }

    private void Reverse(int[] nums, int l, int r) {
        while (l < r) {
            int temp = nums[l];
            nums[l] = nums[r];
            nums[r] = temp;
            l++;
            r--;
        }
    }
}