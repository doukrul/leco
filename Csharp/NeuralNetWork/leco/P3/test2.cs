using System.Text;
public class SolutionP3test2 {
    public int LengthOfLongestSubstring(string s)
    {
        //滑动窗口
        int result = 0;
        int right=0;
        for(int left=0;left<s.Length;left++){
            
        }

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