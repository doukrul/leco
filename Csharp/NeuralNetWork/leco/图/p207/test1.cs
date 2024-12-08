public class SolutionP207test1 {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        if(numCourses==1||prerequisites.Length==0){
            return true;
        }
        List<int>[] edges=new List<int>[numCourses];
        for (int i = 0; i < numCourses; i++){
            edges[i] = new List<int>();
        }
        foreach(var item in prerequisites){
            edges[item[1]].Add(item[0]);
        }

        int []visited=new int[numCourses];
        bool dfs(int vertex){
            
            //当前点正在遍历
            visited[vertex]=1;
            
            foreach(var nv in edges[vertex]){
                //下一个点nv没被遍历
                if(visited[nv]==0){
                    if(!dfs(nv)){
                        return false;
                    }
                }
                else if(visited[nv]==1){
                    return false;;
                }
            }
            //置为遍历过
            visited[vertex]=2;
            return true;
        }
        for(int i=0;i<numCourses;i++){
            if(visited[i]==0){
                if(!dfs(i)){
                    return false;
                }
            }
        }
        return true;
    }
}
