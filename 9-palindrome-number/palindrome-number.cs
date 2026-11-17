public class Solution {
  public bool IsPalindrome(int x) {
    if (x < 0) {
      return false;
    }

    var n = 0;
    var tmp = x;

    while (tmp != 0) {
      n = n * 10 + tmp % 10;
      tmp /= 10;
    }

    return x == n;
  }
}