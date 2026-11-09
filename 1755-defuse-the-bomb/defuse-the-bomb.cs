public class Solution {
  public int[] Decrypt(int[] code, int k) {
    var decrypted = new int[code.Length];

    if (k == 0) {
      return decrypted;
    }

    var start = k > 0 ? 1 : code.Length - 1;
    var end = k > 0 ? k : code.Length + k;
    
    if (k > 0) {
      for (var i = 0; i < code.Length; i++) {
        for (var j = start; j <= end; j++) {
          var index = (i + j) % code.Length;
          decrypted[i] += code[index];
        }
      }
    } else {
      for (var i = 0; i < code.Length; i++) {
        for (var j = start; j >= end; j--) {
          var index = (i + j) % code.Length;
          decrypted[i] += code[index];
        }
      }
    }

    return decrypted;
  }
}