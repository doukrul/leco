using System.Text;
public class SolutionP3test2
{
    public int LengthOfLongestSubstring(string s)
    {
        //滑动窗口方法
        int result = 0;
        //滑动窗口的开始位置
        int left = 0;
        //<key,value>
        Dictionary<char,int> dic=new Dictionary<char, int>();
        //right味滑动窗口的末尾
        for (int right = 0; right < s.Length; right++)
        {
            //检测到重复字符
            if(dic.ContainsKey(s[right])){
                //指向下一个位置
                left=Math.Max(left,dic[s[right]]+1);
                
            }
            //添加进子串
            dic[s[right]]=right;

            //计算最大长度
            result=Math.Max(result,right-left+1);
        }

        return result;
    }

}