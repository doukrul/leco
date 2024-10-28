using System.Text;
using System.Text.RegularExpressions;

public class SolutionP71test1
{
    public string SimplifyPath(string path)
    {
        while(path.Contains("//")){
            path=path.Replace("//","/");
        }

        // Queue<string> queue = new Queue<string>();
        Stack<string> stack = new Stack<string>();
        int i = 0;
        StringBuilder word = new StringBuilder();
        StringBuilder sign = new StringBuilder();
        while (i < path.Length)
        {
            if (Regex.IsMatch(path[i].ToString(), @"^[a-zA-z]$")||path[i]=='_')
            {
                if (sign.ToString().Any())
                {
                    if (sign.ToString().Equals("/"))
                    {
                        stack.Push("/");
                    }
                    else if (sign.ToString().Equals("/./"))
                    {
                        stack.Push("/");
                    }
                    else if (sign.ToString().Equals("/../"))
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push("/");
                        stack.Push(sign.ToString().Replace("/", ""));
                        stack.Push("/");
                    }
                    sign.Clear();
                }
                word.Append(path[i]);
                i++;
            }
            else if (path[i] == '/' || path[i] == '.')
            {
                if (word.Length != 0)
                {
                    // queue.Enqueue(word.ToString());
                    stack.Push(word.ToString());
                    word.Clear();
                }
                sign.Append(path[i]);
                i++;
            }

            if(i==path.Length-1){
                if (path[i]!='/')
                {
                    word.Append(path[i]);
                    stack.Push(word.ToString());
                }
            }
        }
        var result = "/";
        var re=new Stack<string>(stack.Reverse());
        while(stack.Count>0){
            result = result + re.Pop();
        }
        return result;
    }
}