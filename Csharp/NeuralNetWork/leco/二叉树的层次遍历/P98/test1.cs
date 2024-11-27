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
public class SolutionP98test1 {
    public bool IsValidBST(TreeNode root) {
        long pre=(long)int.MinValue-1;
        bool res=true;
        void dfs(TreeNode node){
            if(node==null){
                return;
            }
            dfs(node.left);

                if(node.val<=pre){
                    res=false;
                    return;
                }
            
            pre=node.val;
            dfs(node.right);
        }
        dfs(root);
        return res;
    }
}