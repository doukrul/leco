public class SolutionP205test2
{
    public bool IsIsomorphic(string s, string t)
    {
        Dictionary<char, int> smap = new Dictionary<char, int>();
        Dictionary<char, int> tmap = new Dictionary<char, int>();
        if(s.Length!=t.Length){
            return false;
        }

        for(int i=0;i<s.Length;i++){
            //只存开始位置
            if(!smap.ContainsKey(s[i])){
                smap.Add(s[i], i);
            }
            if(!tmap.ContainsKey(t[i])){
                tmap.Add(t[i],i);
            }
        }

        for (int i = 0; i < s.Length; i++)
        {  
            if(!smap.ContainsKey(s[i])==tmap.ContainsKey(t[i])){
                return false;
            }
        }
        return true;
    }
}