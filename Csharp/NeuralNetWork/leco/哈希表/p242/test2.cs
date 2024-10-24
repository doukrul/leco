public class SolutionP242test2
{
    public bool IsAnagram(string s, string t)
    {
        if(s.Length!=t.Length){
            return false;
        }

        int []a=new int[26];
        int []b=new int[26];
        foreach (char c in s)
        {
            a[c-'a']+=1;
        }
        foreach (char c in t)
        {
            b[c-'a']+=1;
        }
        for(int i=0; i<26;i++){
            if(a[i]!=b[i]){
                return false;
            }
        }
        return true;
    }
}