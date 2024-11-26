/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class SolutionP236test2 {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root==null||root==p||root==q){
            return root;
        }
        //root不是答案,往下看他的子节点是不是
        TreeNode left=LowestCommonAncestor(root.left,p,q);
        TreeNode right=LowestCommonAncestor(root.right,p,q);
        //左子树一直找到结尾都没发现p或q,说明这条路不对,那就在另一条路上
        if(left==null){
            return right;
        }
        //相反
        if(right==null){
            return left;
        }
        return root;
    }
}