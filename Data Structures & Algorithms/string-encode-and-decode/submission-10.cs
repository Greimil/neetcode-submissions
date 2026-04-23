public class Solution {
    public string Encode(IList<string> strs) {
        var sb = new StringBuilder();

        foreach (string str in strs) {
            var len = str.Length;
            sb.Append(len);
            sb.Append("#");
            sb.Append(str);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var res = new List<string>();

        for (int i = 0; i < s.Length;) {

            int j = i;
            while (s[j] != '#') j++;
            
            var num = int.Parse(s.Substring(i, j - i));
            i = j + 1;
            var subString = s.Substring(i,num);
            i = i + num;
            res.Add(subString);

        }


        return res;
    }
}
