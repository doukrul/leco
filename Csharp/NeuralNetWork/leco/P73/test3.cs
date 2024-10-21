public class SolutionP73test3
{
    public void SetZeroes(int[][] matrix)
    {
        //发现了0,就把每个行/列的第一个数变成0,在判断,这样就不用创建判断数组遍历了

        //为什么只设置一个变量就能判断第0行/列呢?
        //因为这两变量只是用来判断当前行/列是不是全0,至于垂直的置0是不用管的,遍历从0-n的,
        //铁定是能每个都遍历到的

        bool row0 = false;
        bool col0 = false;

        // bool[] rowcheck = new bool[matrix.Length];
        // bool [] colcheck = new bool[matrix[0].Length];    

        for (int i = 0; i < matrix.Length; i++)
        {
            if (matrix[i][0] == 0)
            {
                //第0列是否是0
                col0 = true;
            }
        }
        for (int i = 0; i < matrix[0].Length; i++)
        {
            if (matrix[0][i] == 0)
            {
                //第0列是否是0
                row0 = true;
            }
        }

        for (int i = 1; i < matrix.Length; i++)
        {
            for (int j = 1; j < matrix[0].Length; j++)
            {
                if (matrix[i][j] == 0)
                {
                    matrix[i][0]=matrix[0][j]=0;
                }
            }
        }

        for(int i = 0;i<matrix.Length;i++){
            if(matrix[i][0]==0){
                for(int j=0;j<matrix[i].Length;j++){
                    //该行全置0
                    matrix[i][j]=0;
                }
            }
        }
        for(int i = 0;i<matrix[0].Length;i++){
            if(matrix[0][i]==0){
                for(int j=0;j<matrix.Length;j++){
                    //该列全置0
                    matrix[j][i]=0;
                }
            }
        }

        //首行变换
        if(row0==true){
            for(int i = 0;i<matrix[0].Length;i++){
                matrix[0][i]=0;
            }
        }
        //首列变换
        if(col0==true){
            for(int i = 0;i<matrix.Length;i++){
                matrix[i][0]=0;
            }
        }

    }
}