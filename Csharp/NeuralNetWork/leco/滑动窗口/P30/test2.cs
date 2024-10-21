using System;
using System.Collections.Generic;
using System.Text;
public class SolutionP30test2
{
    //暴力解法2
    public IList<int> FindSubstring(string s, string[] words)
    {
        List<int> list = new List<int>();
        int wordlength = words[0].Length;
        int sublength = words.Length * wordlength;
        Dictionary<string,int> dic1= new Dictionary<string,int>();

        foreach (string word in words)
        {
            if(dic1.ContainsKey(word)){
                dic1[word]++;
            }else{
                dic1[word] = 1;
            }
        }
        for (int i = 0; i <= s.Length-sublength; i++)
        {
            //截取总单词长的字符串
            StringBuilder sb = new StringBuilder(s.Substring(i, sublength)){
            };
            //把字符串拆成单词
            Dictionary<string,int> dic2= new Dictionary<string,int>();
            for (int j = 0; j < sublength && j < s.Length; j=j+wordlength)
            {
                //当前单词
                string word=s.Substring(j, wordlength);
                if(!dic1.ContainsKey(word)){
                    break;
                }
                if(dic2.ContainsKey(word)){
                    dic2[word]++;
                }else{
                    dic2[word] = 1; 
                }
                
                if(dic2[word]>dic1[word]){
                    break;
                }
            }
            //检测相同
            if(!dic1.Except(dic2).Any()&&dic1.Count==dic2.Count)
            {
                list.Add(i);
            }
        }

        return list;
    }
}