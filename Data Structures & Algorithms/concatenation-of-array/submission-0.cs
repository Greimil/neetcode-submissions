public class Solution {
    public int[] GetConcatenation(int[] nums) {
        
        int[] result = new int[nums.Length * 2];

        int p1 = 0;

        for(int i = 0; i < result.Length ; i++) {
            if(i == nums.Length ) p1 = 0;

            result[i] = nums[p1];
            p1++;

        }

        return result;

    }
}