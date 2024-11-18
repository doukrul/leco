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
public class SolutionP105test1 {
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        
        if(preorder.Length==0||inorder.Length==0){
            return null;
        }
        Dictionary<int,int> inordermap=new Dictionary<int,int>();
        for(int i=0;i<inorder.Length;i++){
            inordermap.Add(inorder[i],i);
        }
        return help(preorder,0,preorder.Length-1,inorder,0,inorder.Length-1,inordermap);
    }
    
    public TreeNode help(int[] preorder,int prestart,int preend,int[] inorder,int inostart,int inoend,Dictionary<int,int> inordermap){
        if(prestart>preend||inostart>inoend){
            return null;
        }
        //根节点值
        int rootval=preorder[prestart];
        TreeNode node=new TreeNode(rootval);
        //在中序中的位置,左边都是它的左子树
        int rootinino=inordermap[rootval];
        int lefttreelen=rootinino-inostart;
        node.left= help(preorder,prestart+1,prestart+lefttreelen,inorder,inostart,rootinino-1,inordermap);
        node.right=help(preorder,prestart+lefttreelen+1,preorder.Length-1,inorder,rootinino+1,inoend,inordermap);
        return node;
    }
}