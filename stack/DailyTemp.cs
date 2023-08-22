public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var res = new int[temperatures.Length];
        var stack = new Stack<int> ();

        for(int i = 0 ; i < temperatures.Length ; i++){
            int t = temperatures[i];
            while( stack.Any() &&  temperatures[stack.Peek()] < t){
                var prev = stack.Pop();
                 res[prev] = i - prev;
            }
            stack.Push(i);
        }
        return res;
    }
}