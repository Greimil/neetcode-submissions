public class Solution {
   public List<List<int>> ThreeSum(int[] nums)
    {
        List<List<int>> result = new List<List<int>>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            int j = i + 1;
            int l = nums.Length - 1;

            if (i > 0 && nums[i] == nums[i - 1]) continue;

            while (j < l)
            {
                int sumPointers = nums[i] + nums[j] + nums[l];
                if ( sumPointers == 0)
                {
                    List<int> subList = new List<int> { nums[i], nums[j], nums[l] };
                    result.Add(subList);
                    while (j < l && nums[j] == nums[j + 1]) j++;
                    while (j < l && nums[l] == nums[l - 1]) l--;
                    j++;
                    l--;


                }
                else if (sumPointers < 0)
                {
                    j++;

                }
                else
                {

                    l--;
                }


            }



        }

        return result;

    }


}

