public class Solution
{
    public IList<string> FullJustify(string[] words, int maxWidth)
    {
        
        int count = 0;
        string rowword = "";
        List<string> text = new List<string>();
        if (words.Length == 1)
        {
            rowword = words[0];
            while (rowword.Length != maxWidth)
            {
                rowword += ' ';
            }
            text.Add(rowword);
            return text;
        }
        int le = words[0].Length + 1;
        for (int i = 0; i < words.Length-1; ++i)
        {
            le += words[i+1].Length + 1;
            if (le - 1 >= maxWidth)
            {
                //存单词和空格
                for (int j = count; j <= i ; ++j)
                {
                    // text.Add(words[j]);
                    // text.Add(" ");
                    rowword += words[j];
                    //填充单词计数
                    ++count;
                    if (j != i )
                        rowword += ' ';
                }
                int index = 0;
                while (rowword.Length < maxWidth)
                {
                    if (rowword[index] == ' ')
                    {
                        rowword = rowword.Substring(0, index) + ' ' + rowword.Substring(index);
                        index++;
                    }
                    index++;
                    if (index == rowword.Length)
                    {
                        index = 0;
                    }

                }
                text.Add(rowword);
                rowword = "";
                le = 0;
            }
            // else
            // {
            //     le += words[i].Length + 1;
            // }
        }
        //处理最后一行
        if (count < words.Length)
        {
            for (; count < words.Length; count++)
            {
                rowword += words[count];
                if (count != words.Length - 1)
                    rowword += ' ';
            }
            while (rowword.Length < maxWidth)
            {
                rowword += ' ';
            }
            text.Add(rowword);
        }
        return text;
    }
}