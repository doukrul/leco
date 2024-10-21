public class Solution134 {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int currentoil=0;
        int begin=0;
        int totaloil=0;
        int totalcost=0;
        for(int i=0;i<gas.Length;++i){
            totaloil+=gas[i];
            totalcost+=cost[i];
            //当前加油站补油
            currentoil+=gas[i]-cost[i];
            if(currentoil<0){
                //油不够
                currentoil=0;
                begin=i+1;
            }
        }
        if(totalcost>totaloil){
            return -1;
        }
        return begin;
    }
}