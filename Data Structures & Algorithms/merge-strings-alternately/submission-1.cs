public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int l = 0;
        int r = 0;
        var sb = new StringBuilder();

        while (l < word1.Length && r < word2.Length) {
            sb.Append(word1[l]);
            sb.Append(word2[r]);
            l++;
            r++;
        }

        while (l < word1.Length) {
            sb.Append(word1[l]);
            l++;
        }

        while (r < word2.Length) {
            sb.Append(word2[r]);
            r++;
        }



        return sb.ToString();
    }
}