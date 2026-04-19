public class Solution {
      public int LongestConsecutive(int[] nums)
    {

        HashSet<int> set = new HashSet<int>(nums);

        int maxlength = 0;

        foreach (var num in set)
        {

            if (!set.Contains(num - 1))
            {
                int coincidences = 1;
                int i = 1;
                while (set.Contains(num + i))
                {
                    coincidences++;
                    i++;
                }

                maxlength = Math.Max(maxlength, coincidences);
               
            } 
        }

        
        return maxlength;
    }
}
