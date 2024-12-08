public class SolutionP200test1 {
    public int NumIslands(char[][] grid) {
        int res=0;
        void infect(int x,int y){
            if(x<0||y<0||x>=grid.Length||y>=grid[0].Length||grid[x][y]!='1'){
                return;
            }
            grid[x][y]='2';
            infect(x-1,y);
            infect(x,y-1);
            infect(x+1,y);
            infect(x,y+1);
        }
        for(int i=0;i<grid.Length;i++){
            for(int j=0;j<grid[0].Length;j++){
                if(grid[i][j]=='1'){
                    infect(i,j);
                    res++;
                }
            }
        }
        return res;
    }
}