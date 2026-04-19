public class Solution {
    public int RemoveElement(int[] nums, int val) {

        int l = 0;
        int r = 0;

        while(r < nums.Length){

            if(nums[r] != val) {
                nums[l] = nums[r];
                r++;
                l++;
            } else {
                r++;
            }

        } 

        return l;


    }
}