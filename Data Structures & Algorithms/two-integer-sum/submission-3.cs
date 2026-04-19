public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int, int> dic =  new Dictionary<int, int>();
        
        int diference = 0;
        int[] res = new int[2];

        for(int i = 0; i < nums.Length; i++) {
            diference = target - nums[i];

            if(dic.ContainsKey(diference)) {
                
                if(i < dic[diference]) {
                res[0] = i;
                res[1] = dic[diference];    
                break;
                } else {
                    res[0] = dic[diference];  
                    res[1] = i;
                 break;
                }
                
            }


            dic.Add(nums[i], i);

        }

        return res;

    }
}
