public class Solution {
    public int[] SortArray(int[] nums) {

        return mergeSort(nums);
    }


    public int[] mergeSort(int[] nums) {
        return divide(nums);
    }

    public int[] divide(int[] nums) {
        if(nums.Length <= 1) return nums;

        int middle = nums.Length / 2;

        int[] left = divide(nums[..middle]);
        int[] right = divide(nums[middle..]);


        return merge(left.ToList(), right.ToList());
    }

    public int[] merge(List<int> left, List<int> right) {
        var res = new List<int>();
        int l = 0;
        int r = 0;

        while (l < left.Count && r < right.Count) {
            if (left[l] < right[r]) {
                res.Add(left[l]); 
                l++;
            } else {
                res.Add(right[r]);
                r++;
            }
        }

        while(l < left.Count) {
          res.Add(left[l]);
          l++;  
        } 
    
        while(r < right.Count) {
            res.Add(right[r]);
            r++;
        }
    
    
        return res.ToArray();
    
    
    }
}