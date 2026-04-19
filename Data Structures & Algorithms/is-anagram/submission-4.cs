public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        Dictionary<char, int> frecuency = new Dictionary<char, int>();

        for(int i = 0; i < s.Length; i++) {
            if(!frecuency.ContainsKey(s[i])) frecuency[s[i]] = 1;
            else frecuency[s[i]]++;

           
            if(!frecuency.ContainsKey(t[i])) frecuency[t[i]] = -1;
            else frecuency[t[i]]--;
        }

        
        foreach(KeyValuePair<char, int> chart in frecuency) {
            if(chart.Value != 0) return false;
        }

        return true;
    }
}
