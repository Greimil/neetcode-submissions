public class Solution {
       public List<string> LetterCombinations(string digits)
    {
        List<string> res = new List<string>();
        if (string.IsNullOrEmpty(digits)) return res; 
        Dictionary<char, string> map = new Dictionary<char, string>()
    {
        {'2', "abc"},
        {'3', "def"},
        {'4', "ghi"},
        {'5', "jkl"},
        {'6', "mno"},
        {'7', "pqrs"},
        {'8', "tuv"},
        {'9', "wxyz"},
    };

        string getAllLetters(string digits)
        {


            string fullstr = "";

            foreach (char ch in digits)
            {
                if (map.ContainsKey(ch))
                {
                    fullstr += map[ch];
                }
            }

            return fullstr;
        }

        string strCombine = getAllLetters(digits);

        void backtracking(int pos, List<char> path)
        {

            if (pos == digits.Length)
            {
                res.Add(new string(path.ToArray()));
                return;
            }

            string letters = map[digits[pos]];

            foreach (var letter in letters)
            {
                path.Add(letter);

                backtracking(pos + 1, path);

                path.RemoveAt(path.Count - 1);

            }

        }


        backtracking(0, new List<char>());


        return res;
    }
}
