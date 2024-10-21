public class SolutionP48test1
{
    public void Rotate(int[][] matrix)
    {
        int temp = 0;
        if (matrix.Length == 0)
            return;
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix.Length; j++)
            {
                Swap(ref matrix[i][j], ref matrix[j][i]);
            }
            for (int j = 0; j < matrix.Length / 2; j++)
            {
                Swap(ref matrix[i][j], ref matrix[i][matrix.Length - 1 - j]);
            }
        }
    }
    public void Swap<T>(ref T x, ref T y)
    {
        T temp;
        temp = x;
        x = y;
        y = temp;
    }

}
