public class Solution {
    public int MajorityElement(int[] nums) {
        var res = new Dictionary<int, int>();
        int arrLength = nums.Length;
        
        foreach(int num in nums) {

            if(!res.ContainsKey(num)) {
                res[num] = 1;
            } else {
                res[num]++;
            }
        }
        

        foreach(var item in res) {

            if(item.Value > arrLength / 2) return item.Key;

        }

        return -1;



    }
}