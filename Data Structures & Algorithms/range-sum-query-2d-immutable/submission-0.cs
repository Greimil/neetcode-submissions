public class NumMatrix {
    private int[][] p;
    private int rows;
    private int cols;

    public NumMatrix(int[][] matrix) {
        rows = matrix.Length;
        cols = matrix[0].Length;

        // crear prefix (jagged array)
        p = new int[rows + 1][];
        for (int i = 0; i <= rows; i++)
            p[i] = new int[cols + 1];

        // construir prefix sum 2D
        for (int i = 1; i <= rows; i++) {
            for (int j = 1; j <= cols; j++) {
                int curr = matrix[i - 1][j - 1];
                int top = p[i - 1][j];
                int left = p[i][j - 1];
                int diag = p[i - 1][j - 1];

                p[i][j] = curr + top + left - diag;
            }
        }
    }

    public int SumRegion(int row1, int col1, int row2, int col2) {
        return p[row2 + 1][col2 + 1]
             - p[row1][col2 + 1]
             - p[row2 + 1][col1]
             + p[row1][col1];
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */