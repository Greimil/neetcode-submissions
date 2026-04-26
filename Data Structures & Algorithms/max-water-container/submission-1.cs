public class Solution {
    public int MaxArea(int[] heights) {
        int l = 0;
        int r = heights.Length - 1;
        int res = 0;

        while (l < r) {
            int b = r - l;
            int h = Math.Min(heights[l], heights[r]);
            int area = b * h;
            res = Math.Max(area, res);
           
            if(heights[l] < heights[r]) {
                l++;
            } else {
                r--;
            }
            
        }
    
        return res;
    
    }
}
