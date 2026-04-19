public class Solution {
    public void SortColors(int[] nums) {
        int l = 0;
        int c = 0;
        int h = nums.Length - 1;


        while(c <= h) {
            int temp;
            
            if(nums[c] == 0) {
               temp = nums[l];
               nums[l] = nums[c];
               nums[c] = temp;
               c++;
               l++;
            } else if(nums[c] == 2){
                temp = nums[h];
                nums[h] = nums[c];
                nums[c] = temp;
                h--;
            } else {
                c++;
            }


            
        }

      
    }
}