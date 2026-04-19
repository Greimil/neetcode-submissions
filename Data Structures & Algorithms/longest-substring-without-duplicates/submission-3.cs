public class Solution {
       public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> chars = new HashSet<char>();
        int left = 0;
        int right = 0;
        int maxlength = 0;
        while (right < s.Length )
        {

            if (!chars.Contains(s[right]))
            {
                chars.Add(s[right]);
                maxlength = Math.Max(maxlength, chars.Count);
                right++;
            }
            else
            {
                chars.Remove(s[left]);
                left++;

            }

           


        }


        return maxlength;

    }
}
