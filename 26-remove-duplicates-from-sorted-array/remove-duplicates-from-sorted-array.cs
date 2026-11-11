public class Solution {
  public int RemoveDuplicates(int[] nums) {
    var j = 0;
    var i = 0;
    var k = 1;

    while (i < nums.Length) {
      if (nums[i] != nums[j]) {
        k++;
        j++;
        nums[j] = nums[i];
      }
      i++;
    }

    return k;
  }
}