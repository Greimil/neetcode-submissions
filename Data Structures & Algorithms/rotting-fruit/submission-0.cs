public class Solution {
    public int OrangesRotting(int[][] grid)
{
    int rowCount = grid.Length;
    int colCount = grid[0].Length;
    Queue<int[]> queue = new Queue<int[]>();
    int freshCount = 0;

    // 1️⃣ Encolamos todas las podridas y contamos las frescas
    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < colCount; j++)
        {
            if (grid[i][j] == 2) // podrida
            {
                queue.Enqueue(new int[] { i, j });
            }
            else if (grid[i][j] == 1) // fresca
            {
                freshCount++;
            }
        }
    }

    if (freshCount == 0) return 0; // no hay frescas

    int time = 0;

    // 2️⃣ BFS por capas sin bucles internos
    while (queue.Count > 0)
    {
        int size = queue.Count;
        bool pudrimosAlgo = false;

        for (int k = 0; k < size; k++)
        {
            int[] cell = queue.Dequeue();
            int r = cell[0];
            int c = cell[1];

            // Derecha
            if (c + 1 < colCount && grid[r][c + 1] == 1)
            {
                grid[r][c + 1] = 2;
                freshCount--;
                pudrimosAlgo = true;
                queue.Enqueue(new int[] { r, c + 1 });
            }

            // Izquierda
            if (c - 1 >= 0 && grid[r][c - 1] == 1)
            {
                grid[r][c - 1] = 2;
                freshCount--;
                pudrimosAlgo = true;
                queue.Enqueue(new int[] { r, c - 1 });
            }

            // Abajo
            if (r + 1 < rowCount && grid[r + 1][c] == 1)
            {
                grid[r + 1][c] = 2;
                freshCount--;
                pudrimosAlgo = true;
                queue.Enqueue(new int[] { r + 1, c });
            }

            // Arriba
            if (r - 1 >= 0 && grid[r - 1][c] == 1)
            {
                grid[r - 1][c] = 2;
                freshCount--;
                pudrimosAlgo = true;
                queue.Enqueue(new int[] { r - 1, c });
            }
        }

        if (pudrimosAlgo) time++;
    }

    return freshCount == 0 ? time : -1;
}

}
