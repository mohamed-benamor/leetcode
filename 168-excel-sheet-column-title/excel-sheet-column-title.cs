public class Solution {
  public string ConvertToTitle(int columnNumber) {
    var solution = "";

    while (columnNumber > 0) {
      var offset = (columnNumber - 1) % 26;
      columnNumber = (columnNumber - 1) / 26;

      solution = (char)(offset + 65) + solution;
    }

    return solution;
  }
}