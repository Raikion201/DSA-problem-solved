public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int l = 1, r = piles.Max();
        int min = int.MaxValue;
        while( l <= r ){
            int mid = (l + r) / 2;
            int curr = h;
            for (int i = 0 ; i < piles.Length ; i++){
                if( piles[i] % mid == 0){
                    curr -= piles[i] / mid ;
                }else{
                curr -=  ( piles[i] / mid ) + 1 ;
                }
            }
            if(curr >= 0){
                min = Math.Min( min,mid );
                r = mid - 1;
            }else{
                l = mid + 1;
            }
        }
        return min;
    }
}