public class Solution {
   
    public bool Exist(char[][] board, string word)
    {
        bool res = false;


        void backtracking(int row, int col, string path)
        {
            if (res) return;

            if (row < 0 || row >= board.Length || col < 0 || col >= board[0].Length) return;

            if (board[row][col] != word[path.Length]) return;

            if (path.Length + 1 == word.Length)
            {
                res = true;
                return;
            }


            char temp = board[row][col];
            board[row][col] = '#';

            backtracking(row + 1, col, path + temp);
            backtracking(row - 1, col, path + temp);
            backtracking(row, col + 1, path + temp);
            backtracking(row, col - 1, path + temp);

            board[row][col] = temp;


        }



        for (int r = 0; r < board.Length; r++)
        {
            for (int c = 0; c < board[0].Length; c++)
            {

                backtracking(r, c, "");
                if (res) return true;

            }

        }


   


        return res;
    }

}
