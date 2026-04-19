public class Solution {
      public int NumIslands(char[][] grid)
    {

        Dictionary<string, bool> visited = new Dictionary<string, bool>();

        int count = 0;


        void dfs(int x, int y)
        {
            if (x < 0 || x >= grid.Length || y < 0 || y >= grid[0].Length)
            return;

            if (grid[x][y] - 48 == 0 || visited.ContainsKey($"{x}-{y}")) return;

            visited[$"{x}-{y}"] = true;

            
            
            dfs(x, y + 1);
            dfs(x, y - 1);
            dfs(x + 1, y);
            dfs(x - 1, y);

            
           

        }


        for (int x = 0; x < grid.Length; x++)
        {
            for (int y = 0; y < grid[0].Length; y++)
            {
                int position = grid[x][y] - 48;
                if (grid[x][y] - 48 == 1 && (!visited.ContainsKey($"{x}-{y}")))
                {
                    count++;
                    dfs(x, y);

                }

                continue;

            }


        }

        return count;

    }
}
