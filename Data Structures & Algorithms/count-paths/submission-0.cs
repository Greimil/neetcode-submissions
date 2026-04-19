public class Solution {
    public int UniquePaths(int m, int n)
{
    Dictionary<(int, int), int> Memo = new Dictionary<(int, int), int>();

    int Dfs(int i, int j)
    {
        if (Memo.ContainsKey((i, j)))
            return Memo[(i, j)];

        
        if (i >= m || j >= n)
            return 0;

        
        if (i == m - 1 && j == n - 1)
            return 1;

        
        Memo[(i, j)] = Dfs(i + 1, j) + Dfs(i, j + 1);

        return Memo[(i, j)];
    }

    return Dfs(0, 0);
}
}
