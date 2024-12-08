public class SolutionP130test2 {
    public void Solve(char[][] board) {
        int m=board.Length,n=board[0].Length;
        void dfs(int i,int j){
            if(i<0||i>m-1||j<0||j>n-1||board[i][j]!='O'){
                return;
            }
            //把不需要变的O都换成A
            board[i][j]='A';
            dfs(i-1,j);
            dfs(i,j-1);
            dfs(i+1,j);
            dfs(i,j+1);
        }
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(i==0||i==m-1||j==0||j==n-1){
                    dfs(i,j);
                }
            }
        }
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(board[i][j]=='A'){
                    board[i][j]='O';
                }else{
                    board[i][j]='X';
                }
            }
        }
    }
}