public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l = 0;
        int r = numbers.Length - 1;
        int[] res = new int[2];

        while (l < r) {
            var sum = numbers[l] + numbers[r];

            if (sum == target) {
                res[0] = l + 1;
                res[1] = r + 1;
                break;
            } else if (sum > target) {
                r--;

            } else {
                l++;
            }
        }
    
        return res;
    
    }
}
