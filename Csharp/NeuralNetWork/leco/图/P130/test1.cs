public class SolutionP130test1 {
    public void Solve(char[][] board) {
        int m=board.Length,n=board[0].Length;
        bool [][]zombie = new bool[m][];
        for(int i=0;i<m;i++){
            zombie[i]=new bool[n];
        }
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                //在边界
                if(i==0||i==m-1||j==0||j==n-1){
                    if(board[i][j]=='O'&&!zombie[i][j]){
                        dfs(i,j);
                    }
                }
            }
        }
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(board[i][j]=='O'){
                    if(zombie[i][j]==false){
                        board[i][j]='X';
                    }
                }
            }
        }
        void dfs(int i,int j){
            if(i<0||i>m-1||j<0||j>n-1){
                return;
            }
            if(board[i][j]=='X'){
                return;
            }
            if(zombie[i][j]){
                return;
            }
            zombie[i][j]=true;
            dfs(i-1,j);
            dfs(i,j-1);
            dfs(i+1,j);
            dfs(i,j+1);
        }

    }
}