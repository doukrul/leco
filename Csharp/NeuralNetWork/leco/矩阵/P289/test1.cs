public class SolutionP289test1
{
    public void GameOfLife(int[][] board)
    {
        bool[][] dol = new bool[board.Length][];
        for (int i = 0; i < board.Length; i++)
        {
            dol[i] = new bool[board[i].Length];
        }
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                if (board[i][j] == 1)
                {
                    if (DeadOrLife(i, j, board) < 2)
                    {
                        dol[i][j] = false;
                    }
                    else if (DeadOrLife(i, j, board) <= 3)
                    {
                        dol[i][j]=true;
                    }
                    else if(DeadOrLife(i, j, board) > 3){
                        dol[i][j] = false;
                    }

                }else{
                    if (DeadOrLife(i, j, board) == 3){
                        dol[i][j] = true;
                    }
                }

            }
        }
        for(int i=0;i<board.Length;i++){
            for(int j=0;j<board[0].Length;j++){
                if (dol[i][j]==true){
                    board[i][j]=1;
                }else{
                    board[i][j]=0;
                }
            }
        }
    }
    public int DeadOrLife(int i, int j, int[][] board)
    {

        int sum = 0;
        //↖️
        if (i - 1 >= 0 && i - 1 < board.Length && j - 1 >= 0 && j - 1 < board[0].Length)
        {
            sum += board[i - 1][j - 1];
        }
        //⬆️
        if (i - 1 >= 0 && i - 1 < board.Length && j >= 0 && j < board[0].Length)
        {
            sum += board[i - 1][j];
        }
        //↗️
        if (i - 1 >= 0 && i - 1 < board.Length && j + 1 >= 0 && j + 1 < board[0].Length)
        {
            sum += board[i - 1][j + 1];
        }
        //⬅️
        if (i >= 0 && i < board.Length && j - 1 >= 0 && j - 1 < board[0].Length)
        {
            sum += board[i][j - 1];
        }
        //➡️
        if (i >= 0 && i < board.Length && j + 1 >= 0 && j + 1 < board[0].Length)
        {
            sum += board[i][j + 1];
        }
        //↙️
        if (i + 1 >= 0 && i + 1 < board.Length && j - 1 >= 0 && j - 1 < board[0].Length)
        {
            sum += board[i + 1][j - 1];
        }
        //⬇️
        if (i + 1 >= 0 && i + 1 < board.Length && j >= 0 && j < board[0].Length)
        {
            sum += board[i + 1][j];
        }
        //↘️
        if (i + 1 >= 0 && i + 1 < board.Length && j + 1 >= 0 && j + 1 < board[0].Length)
        {
            sum += board[i + 1][j + 1];
        }
        return sum;
    }

}