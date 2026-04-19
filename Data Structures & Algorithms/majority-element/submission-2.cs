public class Solution {
    public int MajorityElement(int[] nums) {
        var dict = new Dictionary<int, int>();


        foreach(int num in nums) {
            if(!dict.ContainsKey(num)) {
                dict.Add(num, 1);
            } else {
                dict[num]++;
            }
        }

        int majority = 0;

        foreach(var item in dict) {
            if(item.Value >= (nums.Length / 2)) {
                majority = item.Key; 
                break;
            } 
        }


        return majority;

    }
}