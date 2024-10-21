using System.Text;
using System.Text.RegularExpressions;

public class Solution125test1
{
    public bool IsPalindrome(string s)
    {

        string sb1 = Regex.Replace(s, @"[^a-zA-Z0-9]", "");
        string sb2=Regex.Replace(sb1,@"[A-Z]",
        m =>{
            return char.IsUpper(m.Value[0])?char.ToLower(m.Value[0]).ToString():m.Value[0].ToString();
        }) ;
        int prev,last;
        prev=0;
        last=sb2.Length-1;
        while(prev<last){
            if(sb2[prev]!=sb2[last]){
                return false;
            }
            ++prev;
            --last;
        }
        return true;
    }
}