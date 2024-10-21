public class SolutionP73test3
{
    public void SetZeroes(int[][] matrix)
    {
        //发现了0,就把每个行/列的第一个数变成0,在判断,这样就不用创建判断数组遍历了
        bool row0=false;
        bool col0=false;

        for(int i=0; i<matrix.Length;i++){
            if(matrix[i][0]==0){
                row0=true;
            }
        }
    }
}