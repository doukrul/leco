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
public class SolutionP530test3 {
    public int GetMinimumDifference(TreeNode root) {
        int min=100000,pre=-1;
        void dfs(TreeNode node){
            if(node==null){
                return;
            }
            dfs(node.left);
            if(node==root){
                pre=node.val;
            }else{
                int cur=node.val-pre;
                if(cur<min){
                    min=cur;
                }
                pre=node.val;
            }
            dfs(node.right);
        }
        dfs(root);
        return min;
    }
}