public class SolutionP242test3
{
    public bool IsAnagram(string s, string t)
    {
        if(s.Length!=t.Length){
            return false;
        }
        int []a=new int[26];

        foreach (char c in s)
        {
            a[c-'a']+=1;
        }
        foreach (char c in t)
        {
            a[c-'a']-=1; 
        }
        for(int i=0; i<26;i++){
            if(a[i]<0){
                return false;
            }
        }
        return true;
    }
}