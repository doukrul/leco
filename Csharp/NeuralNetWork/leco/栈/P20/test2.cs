using System.Text;

public class SolutionP20test2 {
    public bool IsValid(string s) {
        //栈
        Stack<char> stack = new Stack<char> ();
        foreach(char c in s) {
            switch(c){
                case '(':
                    stack.Push (')');
                    break;
                case '{':
                    stack.Push ('}');
                    break;
                case '[':
                    stack.Push (']');
                    break;
                default:
                    if(stack.Any()&&stack.Peek().Equals(c)){
                        stack.Pop();
                    }else{
                        //没有对位括号/
                        return false;
                    }
                    break;
            }
        }
        return true;
    }
}