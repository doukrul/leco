using System.Text;

public class Solution6
{
    public string Convert(string s, int numRows)
    {
        StringBuilder sb = new StringBuilder();
        if (numRows == 1)
        {
            return s;
        }
        Dictionary<(int, int), char> list = new Dictionary<(int, int), char>();

        //列序号
        int l = 0;
        int index = 0;
        int row = 0;
        while (index < s.Length)
        {
            while (row < numRows && index < s.Length)
            {
                list.Add((row, l), s[index++]);
                row++;
            }
            ++l;
            row -= 2;
            if (numRows - 2 > 0)
                while (row > 0 && index < s.Length)
                {
                    list.Add((row, l), s[index++]);
                    row--;
                    l++;
                }
            row = 0;
        }
        row = 0;
        for (int ls = 0; ; ls += numRows - 1)
        {
            if (list.TryGetValue((row, ls), out char c))
            {
                sb.Append(c);
            }
            else
            {
                break;
            }
        }
        while (row < numRows-1)
        {
            for (int ls = 0; ; ++ls)
            {
                if (list.TryGetValue((row, ls), out char c))
                {
                    sb.Append(c);
                }
                else
                {
                    break;
                }
            }
            row++;
        }
        for (int ls = 0; ; ls += numRows - 1)
        {
            if (list.TryGetValue((numRows-1, ls), out char c))
            {
                sb.Append(c);
            }
            else
            {
                break;
            }
        }
        return sb.ToString();
    }
    /*
    0   4   8    12    16
    1 3 5 7 9 11 13 15 
    2   6   10   14
    mid=3-2=1
    numrows=3
    --------------
    0     6       12
    1   5 7    11 13
    2 4   8 10    14
    3     9       15
    -----------------

    */
}