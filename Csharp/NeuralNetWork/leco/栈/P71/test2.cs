using System.Collections.Generic;
using System.Linq;
using System.Text;

public class SolutionP71test2
{
    public string SimplifyPath(string path)
    {
        // 去除多余的斜杠
        while (path.Contains("//"))
        {
            path = path.Replace("//", "/");
        }

        Stack<string> stack = new Stack<string>();

        // 使用 Split 方法分割路径，过滤掉空字符串和 "."
        foreach (var part in path.Split('/', StringSplitOptions.RemoveEmptyEntries))
        {
            if (part == "..")
            {
                if (stack.Count > 0) stack.Pop(); // 如果栈不为空，则弹出顶部元素
            }
            else if (part != ".")
            {
                stack.Push(part); // 将有效的部分压入栈
            }
        }

        // 构建最终的简化路径
        var simplifiedPath = "/" + string.Join("/", stack.Reverse());

        return simplifiedPath;
    }
}