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
public class SolutionP124test3 {
    int max=-1001;
    public int MaxPathSum(TreeNode root) {
        help(root);
        return max;
    }
    private int help(TreeNode node){
        if(node==null){
            return 0;
        }
        int left = Math.Max(0,help(node.left));
        int right = Math.Max(0,help(node.right));
        max=Math.Max(max,node.val+left+right);
        return node.val+Math.Max(left,right);
    }   
}