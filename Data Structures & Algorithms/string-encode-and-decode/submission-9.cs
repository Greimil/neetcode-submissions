public class Solution {
    public string Encode(IList<string> strs) {
        char delimitador = '#';
        StringBuilder sb = new StringBuilder();

        foreach (string str in strs) {
            int len = str.Length;
            sb.Append(len);
            sb.Append(delimitador);
            sb.Append(str);
        }

        return sb.ToString();
    }

 public List<string> Decode(string s) {
        List<string> res = new List<string>();
        int i = 0;

        while (i < s.Length) {
            int j = i;
            while (s[j] != '#') {
                j++;
            }

            int length = int.Parse(s.Substring(i, j - i));

          
            j++; 
            string word = s.Substring(j, length);
            res.Add(word);

    
            i = j + length;
        }

        return res;
    }
}
