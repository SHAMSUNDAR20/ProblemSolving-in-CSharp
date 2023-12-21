public class Solution {
    public int LargestSubmatrix(int[][] matrix) {
        int m = matrix.Length, n = matrix[0].Length;
        for (int i = 1; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (matrix[i][j] == 1) {
                    matrix[i][j] += matrix[i - 1][j];
                }
            }
        }
        int maxArea = 0;
        for (int i = 0; i < m; i++) {
            Array.Sort(matrix[i]);
            for (int j = 0; j < n; j++) {
                maxArea = Math.Max(maxArea, matrix[i][j] * (n - j));
            }
        }
        return maxArea;
    }
}
