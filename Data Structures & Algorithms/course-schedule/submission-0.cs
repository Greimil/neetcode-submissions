public class Solution {
     public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        int[] inDegre = new int[numCourses];
        // 1 - establecemos los indegre en 0
        for (int i = 0; i < numCourses; i++)
        {
            inDegre[i] = 0;
        }


        // 2 - Creamos lista de adjacencia y calculamos los grados de cada nodo
        Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();

        for (int i = 0; i < numCourses; i++)
        {
            graph[i] = new List<int>();
        }

        foreach (var edge in prerequisites)
        {
            int from = edge[0];
            int to = edge[1];
            graph[from].Add(to);
            inDegre[to]++;
        }

        // 3 - creamos la cola y agregamos a la cola los nodos con un grado 0
        Queue<int> queue = new Queue<int>();
        for (int i = 0; i < numCourses; i++)
        {
            if (inDegre[i] == 0) queue.Enqueue(i);
        }

        // 4 - creamos una lista vacia para el orden topologico
        List<int> result = new List<int>();

        while (queue.Count != 0)
        {
            int currentNode = queue.Dequeue();
            result.Add(currentNode);

            foreach (var vecino in graph[currentNode])
            {
                inDegre[vecino]--;
                if (inDegre[vecino] == 0) queue.Enqueue(vecino);


            }

        }

        return result.Count == numCourses;

    }
}
