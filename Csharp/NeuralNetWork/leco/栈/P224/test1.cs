public class SolutionP224 {
    public int Calculate(string s) {
        s.Replace(" ","");
        Stack<string> stack1 = new Stack<string>();
        Stack<char> stack2 = new Stack<char>();
        int number=0;
        //转换逆波兰表达式
        for(int i=0;i<s.Length;i++){
            if(int.TryParse(s[i].ToString(),out var num)){
                number=number*10+num;
                if(i==s.Length-1){
                    stack1.Push(number.ToString());
                }
                else if(!int.TryParse(s[i+1].ToString(),out var n)){
                    stack1.Push(number.ToString());
                    number=0;
                }
            }else{
                if(s[i]=='('){
                    stack2.Push('(');
                }else if(s[i]=='+'){
                    stack2.Push('+');
                }else if(s[i]=='-'){
                    stack2.Push('-');
                }else if(s[i]==')'){
                    while(stack2.Peek()!='('){
                        stack1.Push(stack2.Pop().ToString());
                    }
                    stack2.Pop();
                }
            }
        }
        return 0;
    }
}