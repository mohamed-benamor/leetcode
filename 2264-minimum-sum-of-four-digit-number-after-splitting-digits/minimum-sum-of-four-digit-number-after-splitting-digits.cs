public class Solution {
  public int MinimumSum(int num) {
    var min1 = 9;
    var min2 = 9;
    var solution = 0;

    while (num > 0) {
      var digit = num % 10;
      solution += digit;

      if (digit < min1) {
        min2 = min1;
        min1 = digit;
      } else if (digit < min2) {
        min2 = digit;
      }

      num /= 10;
    }

    return solution + min1 * 9 + min2 * 9;
  }
}