public class Solution {
     public bool ValidTree(int n, int[][] edges)
    {

        Dictionary<int, HashSet<int>> adjacencyList = new Dictionary<int, HashSet<int>>();

        for (int i = 0; i < n; i++)
        {
            adjacencyList[i] = new HashSet<int>();
        }

        foreach (var edge in edges)
        {
            int from = edge[0];
            int to = edge[1];

            adjacencyList[from].Add(to);
            adjacencyList[to].Add(from);
        }

        HashSet<int> visited = new HashSet<int>();

        bool dfs(int node, int prevNode)
        {



            visited.Add(node);

            foreach (var neighbor in adjacencyList[node])
            {

                if (!visited.Contains(neighbor))
                {
                    if (dfs(neighbor, node) == false) return false;
                }
                else if (visited.Contains(neighbor) && neighbor != prevNode)
                {
                    return false;
                }


            }


            return true;

        }


        return dfs(0, -1) && visited.Count == n;

    }
}

