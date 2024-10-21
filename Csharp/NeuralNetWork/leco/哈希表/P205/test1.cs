public class SolutionP205test1
{
    public bool IsIsomorphic(string s, string t)
    {

        //💩做法,beat5%
        Dictionary<char, List<int>> smap = new Dictionary<char, List<int>>();
        Dictionary<char, List<int>> tmap = new Dictionary<char, List<int>>();

        for (int i = 0; i < s.Length; i++)
        {
            if (smap.ContainsKey(s[i]))
            {
                smap[s[i]].Add(i);
            }
            else
            {
                smap.Add(s[i], new List<int>() { i });
            }
            if (tmap.ContainsKey(t[i]))
            {
                tmap[t[i]].Add(i);
            }
            else
            {
                tmap.Add(t[i], new List<int>() { i });
            }
        }
        for (int i = 0; i < s.Length; i++)
        {
            if(smap[s[i]].Except(tmap[t[i]]).Any()||tmap[t[i]].Except(smap[s[i]]).Any()){
                return false;
            }
        }
        return true;
    }
}