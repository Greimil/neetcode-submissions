public class Solution {
    public int CharacterReplacement(string s, int k)
    {

        Dictionary<char, int> count = new Dictionary<char, int>();
        int maxRep = 0;
        int left = 0;
        int right = 0;

        while (right < s.Length)
        {
            int windowsLength = right - left + 1;

            if (count.ContainsKey(s[right]))
                count[s[right]]++;
            else
                count[s[right]] = 1;

            maxRep = Math.Max(maxRep, count[s[right]]);

            if (right - left + 1 - maxRep > k)
            {
                count[s[left]]--;
                left++;
            }


            right++;
        }




        return right - left;
    }
}
