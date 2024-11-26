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
public class SolutionP222test1 {
    public int CountNodes(TreeNode root) {
        return help(root,0);

    }
    private int help(TreeNode node,int size){
        if(node==null){
            return 0;
        }
        size++;
        return help(node.left,size)+help(node.right,size);
    }
}