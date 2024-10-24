public class SolutionP242test1
{
    public bool IsAnagram(string s, string t)
    {
        if(s.Length!=t.Length){
            return false;
        }
        Dictionary<char, int> smap = new Dictionary<char, int>();
        Dictionary<char, int> tmap = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (smap.ContainsKey(c))
            {
                smap[c] += 1;
            }
            else
            {
                smap[c] = 1;
            }
        }
        foreach (char c in t)
        {
            if (tmap.ContainsKey(c))
            {
                tmap[c] += 1;
            }
            else
            {
                tmap[c] = 1;
            }
        }
        for(int i=0; i<s.Length;i++){
            if(!tmap.ContainsKey(s[i])){
                return false;
            }
            if(smap[s[i]]!=tmap[s[i]]){
                return false;
            }
        }
        return true;
    }
}