public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        
    
        string res = "";

        string shortestWord = strs[0];

         foreach (string s in strs) {
             if (s.Length < shortestWord.Length) {
                 shortestWord = s;
             }
        }



        for(int i = 0; i < shortestWord.Length; i ++) {

            char character = shortestWord[i];

            foreach(string word in strs) {
                if(word == shortestWord) continue;

                if(character != word[i]) return res;
                

            }

            res = res + character; 


        }



        return res;
        
    }
}