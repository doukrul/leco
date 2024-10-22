public class SolutionP205test3
{
    public bool IsIsomorphic(string s, string t)
    {
        Dictionary<char, int> map = new Dictionary<char, int>();

        if(s.Length!=t.Length){
            return false;
        }

        for(int i=0;i<s.Length;i++){
            //只存开始位置
            if(!map.ContainsKey(s[i])){
                map.Add(s[i], i);
            }
            if(!map.ContainsKey(t[i])){
                map.Add(t[i],i);
            }
        }

        for (int i = 0; i < s.Length; i++)
        {  
            if(map[s[i]]!=map[t[i]]){
                return false;
            }
        }
        return true;
    }
}