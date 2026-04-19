public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder res = new StringBuilder();


        foreach(string str in strs) {
            res.Append($"{str.Length}#{str}");
        }

        return res.ToString();
    }

    public List<string> Decode(string s) {

        List<string> res = new List<string>();
        
        int i = 0; 

        while (i < s.Length) {
        

        int j = s.IndexOf('#', i);
        
   
        string sLongitud = s.Substring(i, j - i);
        int longitud = int.Parse(sLongitud);
        
        i = j + 1;
        
       
        string palabra = s.Substring(i, longitud);
        res.Add(palabra);
     
        i += longitud;
    }

        return res;

   }
}
