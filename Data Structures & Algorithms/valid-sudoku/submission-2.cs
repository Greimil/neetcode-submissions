public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new HashSet<char>[9];
        var cols = new HashSet<char>[9];
        var boxes = new HashSet<char>[9];

        for (int i = 0; i < 9; i++) {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {
                char curr = board[i][j];

                if (curr == '.') continue;

                int boxIndex = (i / 3) * 3 + (j / 3);

                if (!rows[i].Add(curr)) return false;
                if (!cols[j].Add(curr)) return false;
                if (!boxes[boxIndex].Add(curr)) return false;
            }
        }

        return true;
    }
}
