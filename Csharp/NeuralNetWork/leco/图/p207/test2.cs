
using System;
using System.Collections.Generic;

public class SolutionP207test2
{
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        if (numCourses == 1 || prerequisites.Length == 0)
        {
            return true;
        }

        Dictionary<int, List<int>> edges = new Dictionary<int, List<int>>();
        for(int i=0;i<prerequisites.Length;i++){
            int ver1=prerequisites[i][0];
            int ver2=prerequisites[i][1];
            if(ver1==ver2){
                return false;
            }
            var list=edges.GetValueOrDefault(ver1,new List<int>());
            list.Add(ver2);
            edges[ver1]=list;
        }

        bool dfs(int vertex, List<int> visited)
        {
            if (visited.Contains(vertex))
            {
                return false;
            }
            visited.Add(vertex);
            bool allTrue = true;
            for(int i=0;i<edges.GetValueOrDefault(vertex,new List<int>()).Count;i++){
                int next=edges[vertex][i];
                allTrue &= dfs(next,visited);
                if(!allTrue){
                    return false;
                }
            }
            visited.Remove(vertex);
            return allTrue;
        }
        List<int> visited=new List<int>();
        // 遍历所有课程顶点来调用dfs进行判断
        for (int i = 0; i < numCourses; i++)
        {
            if(!edges.ContainsKey(i))continue;
            if (!dfs(i, visited))
            {
                return false;
            }
        }

        return true;
    }
}