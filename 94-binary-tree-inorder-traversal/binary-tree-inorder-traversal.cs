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
  
  public IList<int> InorderTraversal(TreeNode root) {
    InOrder(root);
    return solution;
  }

  private void InOrder(TreeNode node) {
    if (node is null) {
      return;
    }

    InOrder(node.left);
    solution.Add(node.val);
    InOrder(node.right);
  }
}