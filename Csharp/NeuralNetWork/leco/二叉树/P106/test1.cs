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
public class SolutionP106test1 {
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        if(inorder.Length==0||postorder.Length==0){
            return null;
        }
        Dictionary<int,int> dic=new Dictionary<int,int>();
        for(int i=0;i<inorder.Length;i++){
            dic[inorder[i]]=i;
        }
        return dfs(inorder,0,inorder.Length-1,postorder,0,postorder.Length-1,dic);
    }
    public TreeNode dfs(int []inorder,int ins,int ine,int[]postorder,int pos,int poe,Dictionary<int,int> dic){
        if(ins>ine||pos>poe){
            return null;
        }
        //后序遍历根节点在最后面
        int nodeval=postorder[poe];
        TreeNode node=new TreeNode(nodeval);
        //找中序位置
        int nodeindex=dic[nodeval];
        //左子树长度
        int leftnodesize=nodeindex-ins;
        
        node.left=dfs(inorder,ins,nodeindex-1,postorder,pos,pos+leftnodesize-1,dic);
        node.right=dfs(inorder,nodeindex+1,ine,postorder,pos+leftnodesize,poe-1,dic);
        return node;
    }
}