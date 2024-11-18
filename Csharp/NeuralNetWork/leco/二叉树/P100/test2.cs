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
public class SolutionP100test2 {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        return help(p,q);
    }
    public bool help(TreeNode p,TreeNode q){
        if(p==null&&q==null){
            return true;
        }
        //结构
        if((p==null&&q!=null)||(q==null&&p!=null)){
            return false;
        }
        //值
        if(p!=null&&q!=null&&p.val!=q.val){
            return false;
        }
        return help(p.right,q.right)&&help(p.left,q.left);
        
    }
}