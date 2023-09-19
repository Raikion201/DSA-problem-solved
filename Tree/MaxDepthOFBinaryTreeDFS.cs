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
    public int MaxDepth(TreeNode root) {
        if(root == null){
            return 0 ;
        }
     var s = new Stack<(TreeNode nodeS ,int depth)> ();
     var res = 1;
     s.Push((root , res));
     while(s.Any()){
         var tmp = s.Pop();
         var depth = tmp.depth;
         var node = tmp.nodeS;
         if(node != null){
             res = Math.Max(res,depth);
             s.Push((node.right,depth + 1));
             s.Push((node.left,depth + 1));
         }

     }
    return res ;
}
}