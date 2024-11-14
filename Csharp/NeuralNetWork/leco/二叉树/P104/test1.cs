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
//  public class TreeNode {
//      public int val;
//      public TreeNode left;
//      public TreeNode right;
//      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
//         this.val = val;
//         this.left = left;
//         this.right = right;
//     }
//  }
public class SolutionP104 {
    public int MaxDepth(TreeNode root) {
        int res=0;
        help(root,0,ref res);
        return res;
    }
    public void help(TreeNode node,int len,ref int res){
        if(node==null){
            return ;
        }
        len++;
        if(node.left==null&&node.right==null){
            res=Math.Max(res,len);
        }
        help(node.right,len,ref res);
        help(node.left,len,ref res);
    }
}