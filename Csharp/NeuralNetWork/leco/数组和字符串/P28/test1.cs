public class Solution28
{
    public int StrStr(string haystack, string needle)
    {
        int index = 0;
        int count = 0;
        for (int i = 0; i < haystack.Length; ++i)
        {
            if (haystack[i] == needle[count])
            {
                ++count;
            }
            else
            {
                i = i - count;
                count = 0;
            }
            if (count == needle.Length)
            {
                return i - needle.Length + 1;
            }

        }
        return -1;
    }
}
