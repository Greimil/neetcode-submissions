public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int len = nums.Length;

        int[] prefixArr = new int[len];
        int[] postfixArr = new int[len];
        int[] res = new int[len];

        int prefix = 1;
        for (int i = 0; i < len; i++) {
            prefixArr[i] = prefix;   
            prefix *= nums[i];
        }

        int postfix = 1;
        for (int j = len - 1; j >= 0; j--) {
            postfixArr[j] = postfix; 
            postfix *= nums[j];
        }

        for (int i = 0; i < len; i++) {
            res[i] = prefixArr[i] * postfixArr[i];
        }

        return res;
    }
}