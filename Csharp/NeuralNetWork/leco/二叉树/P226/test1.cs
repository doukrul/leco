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
public class SolutionP226test1 {
    public TreeNode InvertTree(TreeNode root) {
        help(ref root);
        return root;
    }
    public void help(ref TreeNode node){
        if(node==null||(node.right==null&&node.left==null)){
            return ;
        }
        TreeNode temp=node.left;
        node.left=node.right;
        node.right=temp;
        help(ref node.left);
        help(ref node.right);
    }
}