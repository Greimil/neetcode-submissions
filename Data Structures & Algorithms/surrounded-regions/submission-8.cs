public class Solution {
  public void Solve(char[][] board)
    {
        int rows = board.Length;
        if (rows == 0) return;
        int cols = board[0].Length;

        void Dfs(int row, int col)
        {
            if (row < 0 || row >= rows || col < 0 || col >= cols) return;

            if (board[row][col] != 'O') return;

            board[row][col] = 'T';

            Dfs(row + 1, col);
            Dfs(row - 1, col);
            Dfs(row, col + 1);
            Dfs(row, col - 1);
        }


        for (int c = 0; c < cols; c++)
        {
            Dfs(0, c);
            Dfs(rows - 1, c);
        }

        for (int r = 0; r < rows; r++)
        {
            Dfs(r, 0);
            Dfs(r, cols - 1);
        }


        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                if (board[r][c] != 'T')
                    board[r][c] = 'X';
            }
        }


        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                if (board[r][c] == 'T')
                    board[r][c] = 'O';
            }
        }
    }
}
