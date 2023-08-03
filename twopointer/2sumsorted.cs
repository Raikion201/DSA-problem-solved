public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        if(numbers.Length == 2) return new int [] {1,2};
        int left = 0 ;
        int right = numbers.Length - 1;
        while (numbers[left] + numbers[right] != target  ){
            if(numbers[left] + numbers[right] < target ){
                left++;
            }else if(numbers[left] + numbers[right] > target ){
                right--;
            }
        }
        return new int[] {left + 1 , right + 1};
    }
}