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
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
public class SolutionP129test1
{
    public int SumNumbers(TreeNode root)
    {
        int result = 0;

        GetNum(root,0,ref result);
        return result;
    }
    public void GetNum(TreeNode root,int num,ref int result)
    {
        
        if(root==null){
            return ;
        }
        num=num*10+root.val;
        if(root.left==null&&root.right==null){
            result+=num;
        }
        GetNum(root.left,num,ref result);
        GetNum(root.right,num,ref result);
    }
}