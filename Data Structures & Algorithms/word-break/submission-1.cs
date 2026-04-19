public class Solution {
    public bool WordBreak(string s, IList<string> wordDict)
{
    HashSet<string> dict = new HashSet<string>(wordDict);
    Dictionary<int, bool> memo = new Dictionary<int, bool>();

    return Dfs(s, 0, dict, memo);
}

private bool Dfs(string s, int idx, HashSet<string> dict, Dictionary<int, bool> memo)
{
    if (memo.ContainsKey(idx)) return memo[idx];
    if (idx == s.Length) return true;

    foreach (string word in dict)
    {
        if (idx + word.Length <= s.Length && s.Substring(idx, word.Length) == word)
        {
            if (Dfs(s, idx + word.Length, dict, memo))
            {
                memo[idx] = true;
                return true;
            }
        }
    }

    memo[idx] = false;
    return false;
}
}
