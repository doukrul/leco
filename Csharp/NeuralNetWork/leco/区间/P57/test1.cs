public class SolutionP57test1
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        if(intervals.Length==1){
            return new int[1][]{
                new int[]{newInterval[0],newInterval[1]}
            };
        }
        int start = newInterval[0];
        int end = newInterval[1];
        List<int[]> list = new List<int[]>();
        int i=0;
        while(i<intervals.Length&&intervals[i][1]<newInterval[0]){
            list.Add(new int[2]{intervals[i][0],intervals[i][1]});
            i++;
        }
        while(i<intervals.Length&&intervals[i][1]>=newInterval[1]){
            start=Math.Min(intervals[i][0],start);
            end=Math.Max(intervals[i][1],end);
            i++;
        }
        list.Add(new int[]{start,end});
        while(i<intervals.Length){
            list.Add(new int[]{intervals[i][0],intervals[i][1]});
            i++;
        }
        return list.ToArray();
    }
}