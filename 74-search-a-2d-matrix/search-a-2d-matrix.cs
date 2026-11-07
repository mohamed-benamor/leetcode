public class Solution {
  public bool SearchMatrix(int[][] matrix, int target) {
    var rows = matrix.Length;
    var cols = matrix[0].Length;

    var start = 0;
    var end = rows * cols - 1;

    while (start <= end) {
      var mid = start + (end - start) / 2;
      var row = mid / cols;
      var col = mid % cols;

      if (matrix[row][col] == target) {
        return true;
      } else if (matrix[row][col] < target) {
        start = mid + 1;
      } else {
        end = mid - 1;
      }
    }

    return false;
  }
}