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
public class SolutionP100test1 {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        bool res=true;
        help(p,q,ref res);
        return res;
    }
    public void help(TreeNode p,TreeNode q,ref bool res){
        if(p==null&&q==null){
            return ;
        }
        //结构
        if((p==null&&q!=null)||(q==null&&p!=null)){
            res=false;
            return ;
        }
        //值
        if(p!=null&&q!=null&&p.val!=q.val){
            res=false;
            return ;
        }
        help(p.right,q.right,ref res);
        help(p.left,q.left,ref res);
    }
}