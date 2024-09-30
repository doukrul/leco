public class Solution58 {
    public int LengthOfLastWord(string s) {
        int count=0;
        int n=s.Length-1;
        while(n>=0&&s[n]==' ')
            n--;
        for(int i=n;i>=0;--i){
            if(s[i]!=' ')
            count++;
            else{
                break;
            }
        }
        return count;
    }
}