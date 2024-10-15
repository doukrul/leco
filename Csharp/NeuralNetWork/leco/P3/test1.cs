using System.Text;
public class SolutionP3test1 {
    public int LengthOfLongestSubstring(string s)
    {
        //暴力
        int result = 0;
        int sublength = 0;
        int subi=0;

        //子串
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            if (!Haschar(s[i], sb.ToString()))
            {
                sb.Append(s[i]);
                
            }
            else
            {
                result = Math.Max(result, sb.Length);i=i-sb.Length;
                sb.Clear(); 
            }
        }
        result = Math.Max(result, sb.Length);
        return result;
    }
    //重复返回true,否则返回false
    public bool Haschar(char c, string s)
    {
        HashSet<char> chars = new HashSet<char>() { c };

        foreach (char cin in s)
        {
            if (chars.Contains(cin))
            {
                return true;
            }
        }
        return false;
    }
}