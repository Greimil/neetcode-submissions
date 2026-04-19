public class Solution {
    public int CountSubstrings(string s) {
        
        int counter = 0;
        int left = 0;
        int right = 0;

        for (int i = 0; i < s.Length; i++)
        {
            left = i;
            right = i;

            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                counter++;

                left--;
                right++;

            }


            left = i;
            right = i + 1;

            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
               counter++;
                left--;
                right++;

            }



        }  
    
        return counter;
    }
}
