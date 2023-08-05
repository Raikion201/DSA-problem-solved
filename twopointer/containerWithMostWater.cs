public class Solution {
    public int CalSquare(int a,int b, int l,int r){

        int square = (a > b ) ? b*(r-l) : a*(r-l);
        return square;
    }

    public int MaxArea(int[] height) {
       int max = 0;
       int l = 0 ;
       int r = height.Length - 1;

        while( l < r){
          max = Math.Max(max,CalSquare(height[l],height[r],l,r)) ;
            if(height[l] > height[r]){
                r--;
            }else if(height[l] < height[r]){
                l++;
            }else{
                r--;
                l++;
             }
            }
       return max ;
        }
    }
