public class Solution {
  public int[] ConcatWithReverse(int[] nums) {
    var ans = new int[nums.Length * 2];

    for (var i = 0; i < nums.Length; i++) {
      ans[i] = nums[i];
      ans[i + nums.Length] = nums[nums.Length - i -1];
    }

    return ans;
  }
}