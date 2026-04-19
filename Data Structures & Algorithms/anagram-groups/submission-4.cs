public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> res = new List<List<string>>();
        Dictionary<string, List<string>> hash = new Dictionary<string, List<string>>();

        foreach(string s in strs) {
            string uniqueKey =  generateStrKey(s);

            if(!hash.ContainsKey(uniqueKey)) {
                var list = new List<string>();
                list.Add(s);
                hash.Add(uniqueKey,list);
            } else{
               hash[uniqueKey].Add(s); 
            }
        }

        foreach(var item in hash) {
            res.Add(item.Value);
        }


        return res;

    }

    public string generateStrKey(string s) {
        var firm = new int[26];
        StringBuilder sb = new StringBuilder();


        for(int i = 0; i < s.Length; i++) {
            firm[s[i] - 'a']++;
        }

        int idx = 0;
        foreach (var item in firm) {
            sb.AppendLine($"{item}:{idx}");
            idx++;
        }

        return sb.ToString();
    }
}
