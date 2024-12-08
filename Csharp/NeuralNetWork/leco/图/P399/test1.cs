public class SolutionP399test1 {
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries) {
        //顶点:vertex
        //边:Edge
        //权值:Weight
        //graph存储点和与其相连的所有点(有向图)
        Dictionary<string,List<string>>  graph=new Dictionary<string, List<string>>();
        //同步上存储点和对应点相连的所有边权值
        Dictionary<string,List<double>> edgeval=new Dictionary<string,List<double>>();
        double[]ans=new double[queries.Count];
        for(int i=0;i<equations.Count;i++){
            string ver1=equations[i][0];
            string ver2=equations[i][1];

            List<string> list1=graph.GetValueOrDefault(ver1,new List<string>());
            List<string> list2=graph.GetValueOrDefault(ver2,new List<string>());
            list1.Add(ver2);
            list2.Add(ver1);
            if(!graph.ContainsKey(ver1)) {
                graph.Add(ver1,list1);
            }else{
                graph[ver1]=list1;
            }
            if(!graph.ContainsKey(ver2)) {
                graph.Add(ver2,list2);
            }else{
                graph[ver2]=list2;
            }
            List<double> weight1=edgeval.GetValueOrDefault(ver1,new List<double>());
            List<double> weight2=edgeval.GetValueOrDefault(ver2,new List<double>());

            weight1.Add(values[i]);
            weight2.Add(1/values[i]);
            if(!edgeval.ContainsKey(ver1)){
                edgeval.Add(ver1,weight1);
            }else{
                edgeval[ver1]=weight1;
            }
            if(!edgeval.ContainsKey(ver2)){
                edgeval.Add(ver2,weight2);
            }else{
                edgeval[ver2]=weight2;
            }
        }
        //深度优先搜索
        double dfs(string start,string end,HashSet<string> visited,double curval){
            if(graph.ContainsKey(start)&&graph.ContainsKey(end)&&start.Equals(end)){
                return curval;
            }
            //每遍历一个点加入其中,找完了都没有才会弹出
            visited.Add(start);
            for(int i=0;i<graph.GetValueOrDefault(start,new List<string>()).Count;i++){
                string next=graph[start][i];
                double val=edgeval[start][i];
                if(!visited.Contains(next)){
                    double set=dfs(next,end,visited,curval*val);
                    if(set>=0){
                        return set;
                    }
                }
            }
            visited.Remove(start);
            return -1;
        }
        for(int i=0;i<queries.Count;i++){
            ans[i]=dfs(queries[i][0],queries[i][1],new HashSet<string>(),1);
        }

        return ans;
    }


}