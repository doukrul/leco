using System.Text;

public class Solution12
{
    public string IntToRoman(int num)
    {

        Dictionary<int, string> romannum = new Dictionary<int, string>
        {
            {1000, "M"}, {900, "CM"}, {500, "D"}, {400, "CD"},
            {100, "C"}, {90, "XC"}, {50, "L"}, {40, "XL"},
            {10, "X"}, {9, "IX"}, {5, "V"}, {4, "IV"}, {1, "I"}
        };
        StringBuilder sb = new StringBuilder();

        foreach(int sign in romannum.Keys){
            while(num>=sign){
                sb.Append(romannum[sign]);
                num-=sign;
            }
            if(num==0){
                    break;
                }
        }
        return sb.ToString();
    }
}