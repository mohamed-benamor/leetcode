public class Solution {
  public int ReverseDegree(string s) {
    var sum = 0;

    for (var i = 1; i <= s.Length; i++) {
      sum += (26 - (s[i - 1] - 'a')) * i;
    }

    return sum;
  }
}