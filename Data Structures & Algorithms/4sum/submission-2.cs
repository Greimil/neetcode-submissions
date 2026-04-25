public class Solution {
    public List<List<int>> FourSum(int[] nums, int target) {
        Array.Sort(nums);
        int len = nums.Length;
        var res = new List<List<int>>();

        for (int a = 0; a < len; a++) {
            if (a > 0 && nums[a] == nums[a - 1]) {
                continue;
            }

            for (int b = a + 1; b < len; b++) {
                if (b > a + 1 && nums[b] == nums[b - 1]) {
                    continue;
                }
                int c = b + 1;
                int d = len - 1;

                while (c < d) {
                    long total = (long)nums[a] + nums[b] + nums[c] + nums[d];

                    if (total == target) {
                        res.Add(new List<int>() { nums[a], nums[b], nums[c], nums[d] });

                        while (c < d && nums[c] == nums[c + 1]) c++;
                        while (d > c && nums[d] == nums[d - 1]) d--;
                        c++;
                        d--;
                    } else if (total > target) {
                        d--;

                    } else {
                        c++;
                    }
                }
            }
        }

        return res;
    }
}