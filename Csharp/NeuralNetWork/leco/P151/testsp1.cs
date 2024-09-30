public class Solution151sp1
{
    public string ReverseWords(string s)
    {
        List<string> word=s.Split(new string[]{" "},
        StringSplitOptions.RemoveEmptyEntries).toList();
        word.Reverse();
        return string.Join(' ',word);
    }
}