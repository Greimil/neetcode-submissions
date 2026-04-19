public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var res = new int[2];
        var hash = new Dictionary<int, int>();

        for (int j = 0; j < nums.Length; j++) {
            int currentNum = nums[j];
            int diff = target - currentNum;
            
            if(hash.ContainsKey(diff)) {
                res[0] = hash[diff];
                res[1] = j;
                return res;
            } else {
                 hash.Add(currentNum, j);
            }
        }
    
        return res;
    
    }
}
