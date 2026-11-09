public class Solution {
  public int NumberOfAlternatingGroups(int[] colors) {
    var count = 0;

    for (var i = 0; i < colors.Length; i++) {
      var first = colors[i];
      var second = colors[(i + 1) % colors.Length];
      var last = colors[(i + 2) % colors.Length];

      if (first == last && first != second) {
        count++;
      }
    }

    return count;
  }
}