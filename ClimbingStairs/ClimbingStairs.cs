public class Solution {
    public int ClimbStairs(int n) {
        Dictionary<int, int> stairMemory= new Dictionary<int, int>();   
        stairMemory[0] = 0;
        stairMemory[1] = 1;
        stairMemory[2] = 2;
        return  backtracking(n, stairMemory);
        

    }


    public int backtracking(int n, Dictionary<int, int> stairMemory )
    {
        if(stairMemory.ContainsKey(n))
        {
            return stairMemory[n];
        }
        else{
            stairMemory[n] = backtracking(n-1, stairMemory);
            stairMemory[n] += backtracking(n-2, stairMemory);
            return stairMemory[n];
        }
    }


}