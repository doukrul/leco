using System.Text.RegularExpressions;

public class SolutionP150test1
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> num = new Stack<int>();
        for (int i = 0; i < tokens.Length; i++)
        {
            if (int.TryParse(tokens[i], out var number))
            {
                //发现数字压栈
                num.Push(number);
            }
            else
            {
                int num1 = num.Pop();
                int num2 = num.Pop();
                if (tokens[i] == "+")
                {
                    num.Push(num2 + num1);
                }
                else if (tokens[i] == "-")
                {
                    num.Push(num2 - num1);
                }
                else if (tokens[i] == "*")
                {

                    num.Push(num2 * num1);
                }
                else if (tokens[i] == "/")
                {
                    num.Push(num2 / num1);
                }
            }
        }
        return num.Peek();
    }
}