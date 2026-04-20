
public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
   
        var freq = new Dictionary<int, int>();
        foreach (int num in nums) {
            if (!freq.ContainsKey(num))
                freq[num] = 0;
            freq[num]++;
        }

       
        List<int>[] buckets = new List<int>[nums.Length + 1];
        foreach (var pair in freq) {
            int f = pair.Value;
            if (buckets[f] == null)
                buckets[f] = new List<int>();
            buckets[f].Add(pair.Key);
        }

        
        var result = new List<int>();
        for (int i = buckets.Length - 1; i >= 0 && result.Count < k; i--) {
            if (buckets[i] != null) {
                result.AddRange(buckets[i]);
            }
        }

      
        return result.Take(k).ToArray();
    }
}

