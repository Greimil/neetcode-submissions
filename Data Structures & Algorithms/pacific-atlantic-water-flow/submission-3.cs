public class Solution {
   public List<List<int>> PacificAtlantic(int[][] heights)
{
    int row = heights.Length;
    int col = heights[0].Length;
    List<List<int>> result = new List<List<int>>();

    
    HashSet<(int, int)> pacific = new HashSet<(int, int)>();
    HashSet<(int, int)> atlantic = new HashSet<(int, int)>();

    void dfs(int r, int c, ref HashSet<(int, int)> ocean, int prevHeight)
    {
        
        if (r < 0 || r >= row || c < 0 || c >= col)
            return;

        
        if (ocean.Contains((r, c)))
            return;

        
        if (heights[r][c] < prevHeight)
            return;

        
        ocean.Add((r, c));

        
        dfs(r + 1, c, ref ocean, heights[r][c]);
        dfs(r - 1, c, ref ocean, heights[r][c]);
        dfs(r, c + 1, ref ocean, heights[r][c]);
        dfs(r, c - 1, ref ocean, heights[r][c]);
    }

    
    for (int r = 0; r < row; r++)
    {
        dfs(r, 0, ref pacific, heights[r][0]);
        dfs(r, col - 1, ref atlantic, heights[r][col - 1]);
    }

    
    for (int c = 0; c < col; c++)
    {
        dfs(0, c, ref pacific, heights[0][c]);
        dfs(row - 1, c, ref atlantic, heights[row - 1][c]);
    }

    
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            if (pacific.Contains((i, j)) && atlantic.Contains((i, j)))
                result.Add(new List<int> { i, j });
        }
    }

    return result;
}
}
