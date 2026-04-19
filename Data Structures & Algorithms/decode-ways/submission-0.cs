public class Solution {
    public int NumDecodings(string s)
    {
        Dictionary<int, int> memo = new Dictionary<int, int>();

        int dfs(int i)
        {

            if (i == s.Length) return 1;


            if (s[i] == '0') return 0;


            if (memo.ContainsKey(i)) return memo[i];

            int total = 0;

        
        total += dfs(i + 1);


            if (i + 1 < s.Length)
            {
                int num = int.Parse(s.Substring(i, 2));
                if (num >= 10 && num <= 26)
                {
                    total += dfs(i + 2);
                }
            }


            memo[i] = total;
            return total;
        }

        if (s.Length == 0) return 0;
        return dfs(0);
    }

}
