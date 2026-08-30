public class Solution {
    public int Rob(int[] nums) {
        int one = 0;
        int two = 0;

        for(int i = 0; i < nums.Length; i++){
            int temp = one;
            one = Math.Max(two + nums[i], one);
            two = temp;
        }

        return one;
    }
}
