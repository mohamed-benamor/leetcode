public class Solution {
  public int RemoveElement(int[] nums, int val) {
    var i = 0;
    var j = nums.Length - 1;

    while (i <= j) {
      if (nums[i] == val) {
        nums[i] = nums[j];
        j--;
      } else {
        i++;
      }
    }

    return i;
  }
}