public class Solution {
     public int MaxAreaOfIsland(int[][] grid)
    {
        HashSet<string> visitedPos = new HashSet<string>();

        int maxArea = 0;


        int dfs(int x, int y)
        {
            if (x < 0 || x >= grid.Length || y < 0 || y >= grid[0].Length) return 0;

            if (grid[x][y] == 0 || visitedPos.Contains($"{x}-{y}")) return 0;

            visitedPos.Add($"{x}-{y}");
            return 1 + dfs(x, y + 1) + dfs(x, y - 1) + dfs(x + 1, y) + dfs(x - 1, y);

        }



        for (int x = 0; x < grid.Length; x++)
        {


            for (int y = 0; y < grid[0].Length; y++)
            {

                if (grid[x][y] == 1 && !visitedPos.Contains($"{x}-{y}"))
                {
                    int IslandArea = dfs(x, y);
                    maxArea = Math.Max(maxArea, IslandArea);

                }

                continue;

            }


        }



        return maxArea;

    }

}
