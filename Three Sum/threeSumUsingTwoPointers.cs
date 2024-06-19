public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) 
    {
        var result = new List<IList<int>>();
        Array.Sort(nums);
        for(int i = 0; i < nums.Length; i++)
        {
            int left= i+1;
            int right = nums.Length -1;
            var target = 0;
           while(left < right)
           {
                var currentSum = nums[i] + nums[left] + nums[right];
                if(currentSum == target)
                {   
                    List<int> currentSolution = new List<int>{
                        nums[i], nums[left], nums[right]
                    };
                    currentSolution.Sort();
                    var doesSolutionExist = result.Any(x => x.SequenceEqual(currentSolution));  
                    
                    if(!doesSolutionExist)
                    {
                        result.Add(currentSolution);
                    }
                    left++;
                }
                else if(currentSum < target)
                {
                    left++;
                }
                else if(currentSum > target)
                {
                    right--;
                }

           }
        }
        return result;
    }
}