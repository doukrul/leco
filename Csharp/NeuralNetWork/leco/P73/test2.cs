public class SolutionP73test2s
{
    public void SetZeroes(int[][] matrix)
    {
        bool[,] judge = new bool[matrix.Length,matrix[0].Length];

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[i][j] == 0)
                {
                    for (int row = 0; row < matrix.Length; row++)
                        judge[row,j] = true;
                    for (int col = 0; col < matrix[0].Length; col++)
                        judge[i,col] = true;
                }
            }
        }

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if(judge[i,j]==true){
                    matrix[i][j]=0;
                }
            }
        }

    }
}