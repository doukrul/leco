public class SolutionP49test1 {
    public IList<IList<string>> GroupAnagrams(string[] strs) {

        //时间复杂度过高
        List<IList<string>> list = new List<IList<string>>();

        if(strs.Length==0){
            return list;
        }
        
        Dictionary<string,int> dic = new Dictionary<string,int>();
  
        
        foreach(string str in strs){
            if(!dic.ContainsKey(str)){
                dic.Add(str,0);
            }
        }
       
        for(int i=0;i<strs.Length;i++){
            if(dic[strs[i]]==1){
                continue;
            }
            List<string> list2 = new List<string>
            {
                strs[i]
            };
            dic[strs[i]]=1;
            for(int j=i+1;j<strs.Length;j++){
                if(IsAnagram(strs[i],strs[j])){
                    list2.Add(strs[j]);
                    dic[strs[j]]=1;
                }
            }
            list.Add(list2);
        }

        return list;
    }
    public bool IsAnagram(string s, string t)
    {
        if(s.Length!=t.Length){
            return false;
        }
        int []a=new int[26];

        foreach (char c in s)
        {
            a[c-'a']+=1;
        }
        foreach (char c in t)
        {
            a[c-'a']-=1; 
        }
        for(int i=0; i<26;i++){
            if(a[i]<0){
                return false;
            }
        }
        return true;
    }

}