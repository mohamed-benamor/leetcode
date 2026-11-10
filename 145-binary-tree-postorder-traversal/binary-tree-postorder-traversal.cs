/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
  private readonly List<int> solution = new();

  public IList<int> PostorderTraversal(TreeNode root) {
    PostOrder(root);

    return solution;
  }

  private void PostOrder(TreeNode node) {
    if (node is null) {
      return;
    }

    PostOrder(node.left);
    PostOrder(node.right);
    solution.Add(node.val);
  }
}