public class SolutionP36test1
{
    public bool IsValidSudoku(char[][] board)
    {

        HashSet<char> rowcheck = new HashSet<char>();
        HashSet<char> colcheck = new HashSet<char>();
        HashSet<char> boxcheck = new HashSet<char>();
        

        //判断行,判断列
        for (int i = 0; i < board.Length; i++)
        {   
            bool[]row = new bool[board.Length];
            bool[]col = new bool[board.Length];
            bool[]box = new bool[board.Length];
            for (int j = 0; j < board[i].Length; j++)
            {
                if(board[i][j]!='.'){
                    int num=board[i][j]-'1';
                    if(row[num]){
                        return false;
                    }
                    row[num]=true;
                }
                
                if(board[j][i]!='.'){
                    int num=board[j][i]-'1';
                    if(row[num]){
                        return false;
                    }
                    row[num]=true;
                }
                
                //判断3*3
                //判断在哪一块
                int x = i / 3, y = j / 3;
                for (int tempx = x * 3; tempx < x * 3 + 3; tempx++)
                {
                    for (int tempy = y * 3; tempy < y * 3 + 3; tempy++)
                    {
                        if (tempx != i && tempy != j)
                        {
                            if(board[tempx][tempy]==board[i][j]){
                                return false;
                            }
                        }
                    }
                }
            }
        }
        return true;
    }
}