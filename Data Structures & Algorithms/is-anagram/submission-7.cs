public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        var hash = new Dictionary<char, int>();

        foreach(char chart in s){
            
            if(!hash.ContainsKey(chart)) {
                hash.Add(chart,0);
            } 
                hash[chart]++;
        }


        foreach(char chart in t){
            if(!hash.ContainsKey(chart)) return false;
            hash[chart]--;

        }

        foreach(int val in hash.Values) {
            if(val != 0) return false;

        }


        return true;

    }
}

