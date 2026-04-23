public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;

        var hash = new HashSet<int>(nums);
        int res = 0;

        foreach (int num in hash) {

            if (!hash.Contains(num - 1)) {

                int length = 1;
                int curr = num;

                while (hash.Contains(curr + 1)) {
                    curr++;
                    length++;
                }

                res = Math.Max(res, length);
            }
        }

        return res;
    }
}