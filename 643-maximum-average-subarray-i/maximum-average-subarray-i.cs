public class Solution {
  public double FindMaxAverage(int[] nums, int k) {
    var index = 0;
    var sum = 0;

    while (index < k) {
      sum += nums[index++];
    }

    var max = sum;

    for (var i = index; i < nums.Length; i++) {
      sum += nums[i];
      sum -= nums[i - index];
      max = Math.Max(max, sum);
    }

    return (double)max / k;
  }
}