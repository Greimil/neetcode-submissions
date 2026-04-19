public class Solution {
    public bool IsPalindrome(string s) {
        

        var sb = new StringBuilder();

        foreach(char c in s) {
            if(char.IsLetterOrDigit(c)) {
                sb.Append(char.ToLower(c));
            }
        }

        string subClean = sb.ToString();
        int left = 0;
        int right = subClean.Length - 1;


        while(left < right) {

           


            if(subClean[left] != subClean[right]) return false;
            left++;
            right--;

        }
    

        return true;

    }
}
