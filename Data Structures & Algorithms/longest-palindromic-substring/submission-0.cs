public class Solution {
      public string LongestPalindrome(string s)
    {
        int start = 0;
        int end = 0;
        int left = 0;
        int right = 0;

        for (int i = 0; i < s.Length; i++)
        {
            left = i;
            right = i;

            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                if (right - left > end - start)
                {
                    start = left;
                    end = right;
                }

                left--;
                right++;

            }


            left = i;
            right = i + 1;

            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                if (right - left > end - start)
                {
                    start = left;
                    end = right;
                }

                left--;
                right++;

            }



        }

        return s.Substring(start, end - start + 1);

    }

}
