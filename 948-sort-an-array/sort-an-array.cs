public class Solution {
  public int[] SortArray(int[] nums) {
    MergeSort(nums, 0, nums.Length - 1);
    return nums;
  }

  private void MergeSort(int[] arr, int left, int right) {
    if (left == right) {
      return;
    }

    var mid = (left + right) / 2;
    MergeSort(arr, left, mid);
    MergeSort(arr, mid + 1, right);
    Merge(arr, left, mid, right);
  }

  private void Merge(int[] arr, int l, int m, int r) {
    var left = arr[l..(m + 1)];
    var right = arr[(m + 1)..(r + 1)];

    var i = l;
    var j = 0;
    var k = 0;

    while (j < left.Length && k < right.Length) {
      if (left[j] <= right[k]) {
        arr[i++] = left[j++];
      } else {
        arr[i++] = right[k++];
      }
    }

    while (j < left.Length) {
      arr[i++] = left[j++];
    }

    while (k < right.Length) {
      arr[i++] = right[k++];
    }
  }
}