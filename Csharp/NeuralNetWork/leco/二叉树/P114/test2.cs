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
public class SolutionP114test {
    TreeNode last=new TreeNode(0);
    public void Flatten(TreeNode root) {
        if(root==null){
            return;
        }

        Flatten(root.right);
        Flatten(root.left);
        root.right=last;
        root.left=null;
        last=root;

        return;
    }
}