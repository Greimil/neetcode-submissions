public class Solution {
     public int[] FindOrder(int numCourses, int[][] prerequisites)
    {
        int[] inDegre = new int[numCourses];

        Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
        for (int i = 0; i < numCourses; i++)
        {
            graph[i] = new List<int>();
            inDegre[i] = 0;
        }


        foreach (var edge in prerequisites)
        {
            int course = edge[0];     
            int prerequisite = edge[1]; 

            graph[prerequisite].Add(course); 
            inDegre[course]++;               
        }

        Queue<int> queue = new Queue<int>();


        for (int i = 0; i < numCourses; i++)
        {
            if (inDegre[i] == 0) queue.Enqueue(i);
        }

        List<int> res = new List<int>();

        while (queue.Count != 0)
        {
            int actualNode = queue.Dequeue();

            res.Add(actualNode);

            foreach (var neighbor in graph[actualNode])
            {
                inDegre[neighbor]--;
                if (inDegre[neighbor] == 0) queue.Enqueue(neighbor);
            }


        }

        return res.Count == numCourses ? res.ToArray() : new int[0];

    }
}
