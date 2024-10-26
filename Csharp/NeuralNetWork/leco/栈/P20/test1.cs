using System.Text;

public class SolutionP20test1 {
    public bool IsValid(string s) {
        StringBuilder sb=new StringBuilder(s);
        for (int i=0;i<s.Length/2;i++) {
            sb=sb.Replace("()","").Replace("{}","").Replace("[]","");
        }
        return sb.Length==0;
    }
}