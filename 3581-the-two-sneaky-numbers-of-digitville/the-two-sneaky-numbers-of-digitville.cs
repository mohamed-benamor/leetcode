public class Solution {
  public int[] GetSneakyNumbers(int[] nums) {
    var set = new HashSet<int>();
    var solution = new int[2];
    var index = 0;

    foreach (var num in nums) {
      if (!set.Add(num)) {
        solution[index++] = num;
      }
    }

    return solution;
  }
}