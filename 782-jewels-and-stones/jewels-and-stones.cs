public class Solution {
  public int NumJewelsInStones(string jewels, string stones) {
    var map = new Dictionary<char, int>();
    var solution = 0;

    foreach (var jewel in jewels) {
      map[jewel] = 0;
    }

    foreach (var stone in stones) {
      if (map.ContainsKey(stone)) {
        solution++;
      }
    }

    return solution;
  }
}