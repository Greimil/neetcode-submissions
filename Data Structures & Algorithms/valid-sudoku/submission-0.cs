public class Solution {
   public bool IsValidSudoku(char[][] board)
{
    // 1. Verificar filas (no deben tener dígitos repetidos)
    for (int row = 0; row < board.Length; row++)
    {
        HashSet<char> seen = new HashSet<char>();

        for (int col = 0; col < board[row].Length; col++)
        {
            char val = board[row][col];

            if (val == '.') continue;

            if (seen.Contains(val)) return false;

            seen.Add(val);
        }
    }

    // 2. Verificar columnas (no deben tener dígitos repetidos)
    for (int col = 0; col < board.Length; col++)
    {
        HashSet<char> seen = new HashSet<char>();

        for (int row = 0; row < board.Length; row++)
        {
            char val = board[row][col];

            if (val == '.') continue;

            if (seen.Contains(val)) return false;

            seen.Add(val);
        }
    }

    // 3. Verificar los subcuadrantes 3x3 (cada uno no debe tener dígitos repetidos)
    for (int startRow = 0; startRow < 9; startRow += 3)
    {
        for (int startCol = 0; startCol < 9; startCol += 3)
        {
            HashSet<char> seen = new HashSet<char>();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    char val = board[startRow + i][startCol + j];

                    if (val == '.') continue;

                    if (seen.Contains(val)) return false;

                    seen.Add(val);
                }
            }
        }
    }

    return true;
}
}
