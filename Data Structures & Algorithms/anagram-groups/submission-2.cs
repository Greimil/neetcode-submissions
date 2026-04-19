public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var res = new Dictionary<string, List<string>>();

        foreach(string str in strs) {
            string key = generateKey(str);
            
            if(!res.ContainsKey(key)) {
                res[key] = new List<string>();
                res[key].Add(str);
            } else {

                res[key].Add(str);
            }
                


            
        }

        return res.Values.ToList();

    }


    private string generateKey(string str) {
        int[] count = new int[26];

        foreach(char c in str) {
            count[c - 'a']++;
        }

        return string.Join(",", count);


    }


}
