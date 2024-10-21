using System.Text;

public class Solution151
{
    public string ReverseWords(string s)
    {
        s = s.Trim();
        List<string> word = new List<string>();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < s.Length; ++i)
        {
            if (s[i] == ' ')
            {
                if (sb.Length > 0)
                {
                    word.Add(sb.ToString());
                    sb.Clear();
                }
            }
            else
            {
                sb.Append(s[i]);
            }
        }
        if (sb.Length > 0)
        {
            word.Add(sb.ToString());
            sb.Clear();
        }
        sb.Append(word[word.Count - 1]);
        for (int i = word.Count - 2; i >= 0; --i)
        {
            sb.Append(' ');
            sb.Append(word[i]);
        }

        return sb.ToString();
    }
}