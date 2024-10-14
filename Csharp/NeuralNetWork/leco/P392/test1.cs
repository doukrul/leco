public class SolutionP392test1
{
    public bool IsSubsequence(string s, string t)
    {
        int ti = 0;
        if (s == "")
        {
            return true;
        }
        if (t == "")
        {
            return false;
        }
        while (ti <= t.Length - s.Length)
        {
            if (s[0] == t[ti])
            {
                int i = 0, j = ti;
                while (j < t.Length && i < s.Length)
                {
                    if (s[i] == t[j])
                    {
                        ++i;
                    }
                    ++j;
                    if (i == s.Length)
                    {
                        return true;
                    }
                }
            }
            ++ti;
        }
        return false;
    }
}