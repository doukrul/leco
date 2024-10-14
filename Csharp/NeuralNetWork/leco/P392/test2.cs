public class SolutionP392test2
{
    public bool IsSubsequence(string s, string t)
    {
        int si = 0, ti = 0;
        while (si < s.Length && ti < t.Length)
        {
            if(s[si]==t[ti]){
                ++si;
            }
            ti++;
        }
        return si==s.Length;
    }
}