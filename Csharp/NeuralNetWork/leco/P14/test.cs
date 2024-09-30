public class Solution14 {
    public string LongestCommonPrefix(string[] strs) {
        char temp;
        int i=0;
        string result="";
        while(true){
            temp=strs[0][i];
            for(int j=1;j<strs.Length;++j){
                if(temp!=strs[j][i]||i==strs[j].Length){
                    return result;
                }
            }
            result+=temp;
            i++;
            if(i==strs[0].Length){
                return result;
            }
        }
    }
}