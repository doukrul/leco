using System.Text;
using System.Text.RegularExpressions;

public class Solution125test4
{
    public bool IsPalindrome(string s)
    {

        StringBuilder sb = new StringBuilder();
        foreach (char si in s)
        {
            if (char.IsNumber(si) || char.IsLower(si))
            {
                sb.Append(si);
            }
            if (char.IsUpper(si))
            {
                sb.Append(char.ToLower(si));
            }

        }
        int prev = 0;
        int last = sb.Length - 1;
        while (prev < last)
        {
            if (sb[prev] != sb[last])
            {
                return false;
            }
            ++prev;
            --last;
        }
        return true;
    }
}