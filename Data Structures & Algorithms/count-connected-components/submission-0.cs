public class Solution {
    public int CountComponents(int n, int[][] edges)
    {
        Dictionary<int, HashSet<int>> adjList = new Dictionary<int, HashSet<int>>();

        for (int i = 0; i < n; i++) adjList[i] = new HashSet<int>();

        foreach (var edge in edges)
        {
            int from = edge[0];
            int to = edge[1];

            adjList[from].Add(to);
            adjList[to].Add(from);

        }

        HashSet<int> visited = new HashSet<int>();

        void dfs(int node)
        {
            visited.Add(node);


            foreach (var neighbor in adjList[node])
            {
                if (!visited.Contains(neighbor)) dfs(neighbor);
            }

        }

        int components = 0;
        for (int i = 0; i < n; i++)
        {

            if (!visited.Contains(i))
            {
                dfs(i);
                components++;
            }

        } 


        return components;

    }
}
