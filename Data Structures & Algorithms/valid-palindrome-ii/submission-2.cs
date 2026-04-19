public class Solution {
    public bool ValidPalindrome(string s) {
        int l = 0;
        int r = s.Length - 1;

        while (l < r) {
            
            if (!char.IsLetterOrDigit(s[l])) {
                l++;
                continue;
            }
            if (!char.IsLetterOrDigit(s[r])) {
                r--;
                continue;
            }

            
            if (s[l] != s[r]) {
             
                
                return EsPalindromoPuro(s, l + 1, r) || EsPalindromoPuro(s, l, r - 1);
            }

            l++;
            r--;
        }

        return true;
    }

  
    private bool EsPalindromoPuro(string s, int l, int r) {
        while (l < r) {
            
            if (!char.IsLetterOrDigit(s[l])) { l++; continue; }
            if (!char.IsLetterOrDigit(s[r])) { r--; continue; }

            if (s[l] != s[r]) {
                return false;
            }
            l++;
            r--;
        }
        return true;
    }
}