public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var res = new Dictionary<int, int>();        



        foreach(int num in nums) {
            
            if(!res.ContainsKey(num)) {
                res[num] = 1;
            } else {
                res[num]++;
            }

        }

     
        return  res
    .OrderByDescending(x => x.Value)
    .Take(k)
    .Select(x => x.Key)
    .ToArray();

        

    }
}
