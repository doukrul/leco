public class SolutionP452test1 {
    public int FindMinArrowShots(int[][] points) {
        int result=1;
        Array.Sort(points,(a,b) =>a[0].CompareTo(b[0]));
        
        int end=points[0][1];
        
        for(int i=1;i<points.Length;i++){
            //与前区间没有重叠
            if(points[i][0]>end){
                result+=1;
                end=points[i][1];
            }
            else{
                end=Math.Min(points[i][1],end);
            }
        }
        return result;
    }
}