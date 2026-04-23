public class Solution {
    public List<int> MajorityElement(int[] nums) {
        var dict = new Dictionary<int, int>();

        foreach (int num in nums) {
            if (!dict.ContainsKey(num)) {
                dict.Add(num, 1);
            } else {
                dict[num]++;
            }
        }

        List<int> res = new List<int>();

        foreach (var item in dict) {
            if (item.Value > (nums.Length / 3)) {
                res.Add(item.Key);
            }
        }

        return res;
    }
}