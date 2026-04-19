public class Solution {
    public void islandsAndTreasure(int[][] grid)
{
    int rows = grid.Length;
    int cols = grid[0].Length;
    Queue<int[]> queue = new Queue<int[]>();

    // 1. Añadir todos los cofres a la cola (distancia 0)
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (grid[i][j] == 0) // cofre
            {
                queue.Enqueue(new int[] { i, j });
            }
        }
    }

    // Direcciones para los vecinos: arriba, abajo, izquierda, derecha
    int[][] directions = new int[][]
    {
        new int[] { -1, 0 },
        new int[] { 1, 0 },
        new int[] { 0, -1 },
        new int[] { 0, 1 }
    };

    while (queue.Count > 0)
    {
        int[] cell = queue.Dequeue();
        int r = cell[0];
        int c = cell[1];

        // Para cada vecino válido
        foreach (var dir in directions)
        {
            int nr = r + dir[0];
            int nc = c + dir[1];

            // Validar que esté dentro de los límites
            if (nr >= 0 && nr < rows && nc >= 0 && nc < cols)
            {
                // Solo si es tierra (INF)
                if (grid[nr][nc] == 2147483647)
                {
                    // Actualizar la distancia con la del nodo actual + 1
                    grid[nr][nc] = grid[r][c] + 1;
                    // Añadir vecino para seguir la propagación
                    queue.Enqueue(new int[] { nr, nc });
                }
            }
        }
    }
}

}
