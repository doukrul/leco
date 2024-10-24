using System.Text;

public class SolutionP290test2
{
    public bool WordPattern(string pattern, string s)
    {
        //成功
        Dictionary<char, string> ptowords = new Dictionary<char, string>();

        Dictionary<string,char> wordtop=new Dictionary<string,char>();
        int sign=0;
        int start = 0;
        for (int i = 0; i <= s.Length; i++)
        {
            if(i==s.Length||s[i]==' '){
                //获得单词
                string word=s.Substring(start,i-start);
                start=i+1;
                
                if(sign==pattern.Length){
                    return false;
                }
                if(ptowords.ContainsKey(pattern[sign])){
                    if(!ptowords[pattern[sign]].Equals(word)){
                        return false;
                    }
                }else{
                    ptowords.Add(pattern[sign],word);
                }
                if(wordtop.ContainsKey(word)){
                    if(wordtop[word]!=pattern[sign]){
                        return false;
                    }
                }else{
                    wordtop.Add(word,pattern[sign]);
                }
                sign++;

            }
        }
        if(ptowords.Count!=wordtop.Count||sign!=pattern.Length){
            return false;
        }

        return true;
    }
}