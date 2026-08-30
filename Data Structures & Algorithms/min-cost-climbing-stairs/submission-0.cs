public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int one = 0;
        int two = 0;
        for(int i = 2; i <= cost.Length; i++){
            int temp = one;
            one = Math.Min(one + cost[i-1], two + cost[i-2]);
            two = temp;
        }

        return one;
    }
}
