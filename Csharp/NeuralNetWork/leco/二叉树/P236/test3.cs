/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class SolutionP236test3 {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root==null||root==p||root==q){
            return root;
        }
        if(LowestCommonAncestor(root.left,p,q)==null){
            return LowestCommonAncestor(root.right,p,q);
        }
        if(LowestCommonAncestor(root.right,p,q)==null){
            return LowestCommonAncestor(root.left,p,q);
        }
        return root;
    }
}