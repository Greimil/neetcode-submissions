public class Solution {
  
    public int MaxArea(int[] heights)
    {
        int max = 0;

        int left = 0;

        int right = heights.Length - 1;


        while (left < right)
        {

            int b = right - 1 - left + 1;
            int a = Math.Min(heights[left], heights[right]);

            max = Math.Max(max, b * a);


            if (heights[left] < heights[right])
            {

                left++;

            }
            else
            {

                right--;
            }


        }


        return max;

    }
}
