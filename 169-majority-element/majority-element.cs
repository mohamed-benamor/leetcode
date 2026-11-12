public class Solution {
  public int MajorityElement(int[] nums) {
    var solution = 0;
    var count = 0;

    foreach (var num in nums) {
      if (count == 0) {
        solution = num;
      }

      count += (solution == num) ? 1 : -1;
    }

    return solution;
  }
}