public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1;
        int right = piles.Max();
        int result = right;

        while(left <= right){
            int mid = (left + right) / 2;

            if(CanFinish(piles, mid, h)){
                result = mid;        
                right = mid - 1;
            } else {
                left = mid + 1;      
            }
        }
        return result;


    }
    private bool CanFinish(int[] piles, int k, int h){
        int totalHours = 0;

        foreach(int pile in piles){
            totalHours += (pile + k - 1) / k;  
        }

        return totalHours <= h;
    }
}
