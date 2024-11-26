/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class SolutionP236test1 {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        return help(root,p,q);
    }
    private TreeNode help(TreeNode node,TreeNode p,TreeNode q){
        if(node==null){
            return null;
        }
        TreeNode left=help(node.left,p,q);
        TreeNode right=help(node.right,p,q);
        if(left==p||right==q){
            return help(node.left,p,q);
        }
        if(left==q||right==p){
            return help(node.right,p,q);
        }
        if(left==p&&right==q){
            return node;
        }
        return node;
    }
}