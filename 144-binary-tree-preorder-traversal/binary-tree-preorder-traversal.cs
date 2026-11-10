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

  public IList<int> PreorderTraversal(TreeNode root) {
    PreOrder(root);

    return solution;
  }

  private void PreOrder(TreeNode node) {
    if (node is null) {
      return;
    }

    solution.Add(node.val);
    PreOrder(node.left);
    PreOrder(node.right);
  }
}
