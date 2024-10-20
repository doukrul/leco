public class SolutionP36test1
{
    public bool IsValidSudoku(char[][] board)
    {
        for (int i = 0; i < board.Length; i++)
        {
            bool[] row = new bool[board.Length];
            bool[] col = new bool[board.Length];

            for (int j = 0; j < board[i].Length; j++)
            {
                //判断行,判断列
                if (board[i][j] != '.')
                {
                    int num = board[i][j] - '1';
                    if (row[num])
                    {
                        return false;
                    }
                    row[num] = true;
                }

                if (board[j][i] != '.')
                {
                    int num = board[j][i] - '1';
                    if (col[num])
                    {
                        return false;
                    }
                    col[num] = true;
                }
            }
        }

        //判断3*3
        //外层9*9划分成9块3*3
        for (int sign = 0; sign < 9; sign++)
        {
            bool[] box = new bool[board.Length];
            //每块3*3内部
            for (int i = sign % 3 * 3; i < sign % 3 * 3 + 3; i++)
            {
                for (int j = sign / 3 * 3; j < sign / 3 * 3 + 3; j++)
                {
                    if (board[i][j] != '.')
                    {
                        int num = board[i][j] - '1';
                        if (box[num])
                        {
                            return false;
                        }
                        box[num] = true;
                    }
                }
            }
        }
        return true;
    }
}