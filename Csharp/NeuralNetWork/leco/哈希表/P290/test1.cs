using System.Text;

public class SolutionP290test1
{
    //单个字典,失败了通过不了
    public bool WordPattern(string pattern, string s)
    {
        Dictionary<char, string> words = new Dictionary<char, string>();

        StringBuilder word = new StringBuilder();
        int sign = 0;
        for (int j = 0; j <= s.Length; j++)
        {
            if (s[j] != ' '&&j<s.Length)
            {
                word.Append(s[j]);
            }
            else
            {
                if (words.ContainsKey(pattern[sign]))
                {
                    if (!words[pattern[sign]].Equals(word.ToString()))
                    {
                        return false;
                    }
                    sign++;
                }
                else
                {
                    words.Add(pattern[sign], word.ToString());
                    sign++;
                    word.Clear();
                }

            }
        }


        return true;
    }
}