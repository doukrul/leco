using System;
using System.Collections.Generic;
using System.Text;
public class Solution
{
    public IList<int> FindSubstring(string s, string[] words)
    {
        List<int> list = new List<int>();
        List<string> set = new List<string>();
        int wordlength = words[0].Length;
        int sublength = words.Length * wordlength;

        foreach (string word in words)
        {
            set.Add(word);
        }
        set.Sort();
        for (int i = 0; i <= s.Length-sublength; i++)
        {
            //截取总单词长的字符串
            StringBuilder sb = new StringBuilder(s.Substring(i, sublength)){
            };
            //把字符串拆成单词
            List<string> set2 = new List<string>();
            for (int j = 0; j < sublength && j < s.Length; j=j+wordlength)
            {
                set2.Add(sb.ToString().Substring(j,wordlength));
            }
            set2.Sort();
            //检测相同
            if(set.SequenceEqual(set2))
            {
                list.Add(i);
            }
        }

        return list;
    }
}