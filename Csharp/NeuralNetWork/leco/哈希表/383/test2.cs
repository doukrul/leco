public class SolutionP383test2 {
    public bool CanConstruct(string ransomNote, string magazine) {
        int []judge=new int[26];
        foreach (char c in ransomNote){
            judge[c-'a']-=1;
        }
        foreach (char c in magazine){
            judge[c-'a']+=1;
        }
        for (int i=0;i<26;i++){
            if(judge[i]<0){
                return false;
            }
        }
        return true;
    }
}