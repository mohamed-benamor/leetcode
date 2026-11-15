public class Solution {
  public int DifferenceOfSums(int n, int m) {
    var sum = 0;

    for (var i = 1; i <= n; i++) {
      sum += i % m == 0 ? -i : i;
    }

    return sum;
  }
}