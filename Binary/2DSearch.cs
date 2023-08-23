public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int top = 0;
        int bot = matrix.Length - 1;

        while(bot >= top){
            int midRow = ((top + bot ) / 2 );
            if( target < matrix[midRow][0] ){
                bot = midRow - 1;
            }else if (target > matrix[midRow][0]){
                top = midRow + 1;
            }else {
                return true;
            }
            int right = matrix[0].Length - 1;
            int left = 0;
            while(right >= left){
            int midCol = (left + right) / 2 ;
             if (matrix[midRow][midCol] > target) {
                right = midCol - 1;
            } else if (matrix[midRow][midCol] < target) {
                left = midCol + 1;
            } else {
                return true;
            }
            }
        }
        return false;
    }
}