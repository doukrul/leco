//无向连通图
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
public class SolutionP133test1 {
    public Node CloneGraph(Node node) {
        if(node==null){
            return null;
        }
        Dictionary<int,Node> dic=new Dictionary<int,Node>();
        void help(Node node){
            if(dic.ContainsKey(node.val)){
                return;
            }
            Node newnode=new Node(node.val);
            dic.Add(newnode.val,newnode);
            foreach(var itemnode in node.neighbors){
                //没有拷贝这个节点
                if(!dic.ContainsKey(itemnode.val)){
                    help(itemnode);
                }
                newnode.neighbors.Add(dic[itemnode.val]);
            }
        }
        help(node);
        return dic[1];
    }
}