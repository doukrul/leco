using System.Text;
public class SolutionP3test4
{
    // test2的改进
    public int LengthOfLongestSubstring(string s)
    {
        //暴力
        int result = 0;
        int left=0;
        HashSet<char> hash = new HashSet<char>();
        //right味滑动窗口的末尾
        for (int right = 0; right < s.Length; right++)
        {
            //检测到重复字符
            while (hash.Contains(s[right]))
            {
                hash.Remove(s[left]);
                left++;
            }
            //添加进子串
            hash.Add(s[right]);

            //计算最大长度
            result = Math.Max(result, hash.Count());
        }

        return result;
    }
}