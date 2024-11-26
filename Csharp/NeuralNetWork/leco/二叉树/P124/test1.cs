
using System.Diagnostics.SymbolStore;

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
public class SolutionP124test1 {
    int max1=-1001;
    public int MaxPathSum(TreeNode root) {
        return Math.Max(getmax(root),max1);
    }
    private int getmax(TreeNode node){
        if(node==null){
            return -1001;
        }
        int left=getmax(node.left);
        int right=getmax(node.right);
        max1=new List<int>(){max1,node.val+left+right,left,right}.Max();
        return new List<int>(){node.val,node.val+left,node.val+right}.Max();
    }
}