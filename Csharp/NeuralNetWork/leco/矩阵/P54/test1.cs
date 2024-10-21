public class SolutionP54test1
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        //记录第几圈
        int count = 0;
        int rowLength = matrix.Length; //有几行
        int colLength = matrix[0].Length;//有几列
        List<int> result = new List<int>();
        while (result.Count != rowLength * colLength)
        {
            //右,下,左,上
            //➡️
            for (int col = count; col < colLength - count; col++)
            {
                result.Add(matrix[count][col]);
            }
            //⬇️
            for (int row = count + 1; row < rowLength - count; row++)
            {

                result.Add(matrix[row][colLength - count - 1]);
            }


            //⬅️
            if (rowLength - count - 1 > count)
                for (int col = colLength - count - 2; col >= count; col--)
                {

                    result.Add(matrix[rowLength - count - 1][col]);
                }
            //⬆️
            if (colLength - count - 1 > count)
                for (int row = rowLength - count - 2; row > count; row--)
                {
                    result.Add(matrix[row][count]);
                }
            count++;
        }



        return result;
    }
}