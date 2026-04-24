public class Solution {
    public bool ValidPalindrome(string s) {
        int l = 0;
        int r = s.Length - 1;

        while (l < r) {
            if (s[l] != s[r]) {
                break;
            }

            l++;
            r--;
        }

        return IsvalidPalindrome(s, l) || IsvalidPalindrome(s, r);
    }


    public bool IsvalidPalindrome(string s,int idxToSkip){

        int l = 0;
        int r = s.Length - 1;

        while(l < r) {
            if(l == idxToSkip) l++;
            if(r == idxToSkip) r--;

            if(s[l] != s[r] ) return false;
            l++;
            r--;

        }

        return true;


    }


}