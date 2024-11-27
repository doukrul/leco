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
public class SolutionP230test1 {
    public int KthSmallest(TreeNode root, int k) {
        int Count=0;
        int res=0;
        void dfs(TreeNode node){
            if(node==null){
                return;
            }
            dfs(node.left);
            Count++;
            if(Count==k){
                res=node.val;
            }
            dfs(node.right);
        }
        dfs(root);
        return res;
    }
}