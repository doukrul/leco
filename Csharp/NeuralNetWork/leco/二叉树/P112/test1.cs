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
public class SolutionP112test1 {
    public bool HasPathSum(TreeNode root, int targetSum) {
        if(root==null){
            return false;
        }
        return help(root,targetSum);
    }
    private bool help(TreeNode node,int count){
        if(node==null){
            return false;
        }
        if(node.left==null&&node.right==null){
            return count-node.val==0;
        }
        count-=node.val;
        return help(node.left,count)||help(node.right,count);
    }
}