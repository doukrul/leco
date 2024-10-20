public class SolutionP73test1 {
    public void SetZeroes(int[][] matrix) {
        bool [][] judge = new bool[matrix.Length][];
        for(int i=0; i<matrix.Length;i++){
            judge[i]=new bool[matrix[0].Length];
        }
        for (int i = 0;i<matrix.Length;i++) {
            for (int j = 0;j<matrix[0].Length;j++){
                if(matrix[i][j]==0){
                    for(int row = 0;row<matrix.Length;row++)
                    judge[row][j]=true;
                    for(int col = 0;col<matrix[0].Length;j++)
                    judge[i][col]=true;
                }
            }
        }

    }
}