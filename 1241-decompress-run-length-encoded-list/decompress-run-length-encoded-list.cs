public class Solution {
  public int[] DecompressRLElist(int[] nums) {
    var decompressed = new List<int>();

    for (var i = 0; i < nums.Length; i += 2) {
      for (var j = 0; j < nums[i]; j++) {
        decompressed.Add(nums[i + 1]);
      }
    }

    return decompressed.ToArray();
  }
}