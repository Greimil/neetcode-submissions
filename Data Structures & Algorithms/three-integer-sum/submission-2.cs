public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<List<int>> res = new List<List<int>>();

        for (int i = 0; i < nums.Length - 2; i++) {

          
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            int l = i + 1;
            int r = nums.Length - 1;

            while (l < r) {
                int sum = nums[i] + nums[l] + nums[r];

                if (sum == 0) {
                    res.Add(new List<int> { nums[i], nums[l], nums[r] });

                   
                    while (l < r && nums[l] == nums[l + 1]) l++;
                    while (l < r && nums[r] == nums[r - 1]) r--;

                   
                    l++;
                    r--;
                }
                else if (sum < 0) {
                    l++;
                }
                else {
                    r--;
                }
            }
        }

        return res;
    }
}
