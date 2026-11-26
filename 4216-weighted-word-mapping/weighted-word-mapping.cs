public class Solution {
  public string MapWordWeights(string[] words, int[] weights) {
    var solution = new StringBuilder();
    
    foreach (var word in words) {
      var sum = 0;

      foreach (var c in word) {
        sum += weights[c - 'a'];
      }

      solution.Append((char)('z' - sum % 26));
    }

    return solution.ToString();
  }
}