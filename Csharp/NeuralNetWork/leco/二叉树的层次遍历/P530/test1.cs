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
public class SolutionP530test1 {
    int min=100000;
    int pre=-1;
    public int GetMinimumDifference(TreeNode root) {
        //二叉搜索树中做中序遍历得到的是
        List<int> list=new List<int>();
        inorder(root);
        return min;
    }
    private void inorder(TreeNode node) {
        if(node==null){
            return;
        }
        
        inorder(node.left);
        if(pre<0){
            pre=node.val;
        }else{
            min=Math.Min(min,node.val-pre);
            pre=node.val;
        }
        inorder(node.right);
    }
}