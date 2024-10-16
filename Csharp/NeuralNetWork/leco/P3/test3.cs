using System.Text;
public class SolutionP3test3
{
    // test2的改进
    public int LengthOfLongestSubstring(string s)
    {
        //暴力
        int result = 0;
        HashSet<char> hash = new HashSet<char>();
        //right味滑动窗口的末尾
        for (int right = 0; right < s.Length; right++)
        {
            //检测到重复字符
            if (hash.Contains(s[right]))
            {
                right = right - hash.Count() + 1;
                //清空hashset内容
                hash.Clear();
            }
            //添加进子串
            hash.Add(s[right]);

            //计算最大长度
            result = Math.Max(result, hash.Count());
        }

        return result;
    }
}