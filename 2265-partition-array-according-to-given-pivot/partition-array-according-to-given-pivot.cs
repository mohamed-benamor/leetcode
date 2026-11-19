public class Solution {
  public int[] PivotArray(int[] nums, int pivot) {
    var result = new int[nums.Length];
    var j = 0;

    for (var i = 0; i < nums.Length; i++) {
      if (nums[i] < pivot) {
        result[j++] = nums[i];
      }
    }

    for (var i = 0; i < nums.Length; i++) {
      if (nums[i] == pivot) {
        result[j++] = nums[i];
      }
    }

    for (var i = 0; i < nums.Length; i++) {
      if (nums[i] > pivot) {
        result[j++] = nums[i];
      }
    }

    return result;
  }
}