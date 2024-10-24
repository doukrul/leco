public class SolutionP56test1 {
    public int[][] Merge(int[][] intervals) {
        // List<int[][]> result = new List<int[][]>();
        int [][]result=new int[intervals.Length][];
        for (int i = 0;i<intervals.Length;i++){
            result[i]=new int[2];
        }
        result[0][0]=intervals[0][0];
        int start=0,end=0;
        Comparison<int[]> comparer = (x,y) => x[0].CompareTo(y[0]);
        Array.Sort(intervals,comparer);
        int sign=0;
        for(int i=1;i<intervals.Length;i++){
            if(intervals[i][0]<=intervals[i-1][1]){
                end=i;
            }else{
                if(end==start){
                    result[sign][0]=intervals[start][0];
                    result[sign][1]=intervals[start][1];
                }else{
                    result[sign][0]=intervals[start][0];
                    result[sign][1]=intervals[end][1];
                }
                sign++;
                start=end=i;
            }
            if(end==intervals.Length){
                if(end==start){
                    result[sign][0]=intervals[start][0];
                    result[sign][1]=intervals[start][1];
                }else{
                    result[sign][0]=intervals[start][0];
                    result[sign][1]=intervals[end][1];
                }
            }
        }
    }
}