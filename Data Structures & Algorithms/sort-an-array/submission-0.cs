public class Solution {
    public int[] SortArray(int[] nums) {
        
        return mergeSort(nums);

    }


    private int[] mergeSort(int[] nums){

        int length = nums.Length;
        
        if(length <= 1) return nums;


        int middle = length / 2;

        int[] left = nums[..middle];
        int[] rigth = nums[middle..];


        return merge(mergeSort(left), mergeSort(rigth));
    }

    private int[] merge(int[] left, int[] rigth){
        List<int> res = new List<int>();
        int j = 0;
        int k = 0;

        while(j < left.Length &&  k < rigth.Length) {

            if(left[j] <= rigth[k]) {
                res.Add(left[j]);
                j++;
            } else{
                res.Add(rigth[k]);
                k++;
            }
        }

        while(j < left.Length) {
            res.Add(left[j]);
            j++;
        }

        while(k < rigth.Length) {
            res.Add(rigth[k]);
            k++;
        }

        return res.ToArray();

    }


}