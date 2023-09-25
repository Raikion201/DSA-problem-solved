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

 int result = -1;
public int DFS(TreeNode root) {
        if(root == null){
            return -1;
        }
        int left = 1 + DFS(root.left);
        int right = 1 + DFS(root.right);
        result = Math.Max(result,(left + right));
        return Math.Max(left,right);
    }

    public int DiameterOfBinaryTree(TreeNode root) {
        DFS(root);
        return result;
    }
}