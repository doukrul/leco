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
public class SolutionP101test1 {
    public bool IsSymmetric(TreeNode root) {
        return help(root.left, root.right);
    }
    public bool help(TreeNode node1,TreeNode node2){
        if(node1==node2){
            return true;
        }else if((node1!=null&&node2==null)||(node1==null&&node2!=null)){
            return false;
        }else{
            return node1.val==node2.val&&help(node1.left,node2.right)&&help(node1.right,node2.left);
        }
    }
}