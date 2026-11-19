public class Solution {
  public int MinPartitions(string n) {
    var solution = n[0];

    for (var i = 1; i < n.Length; i++) {
      if (n[i] > solution) {
        solution = n[i];
      }
    }

    return solution - '0';
  }
}