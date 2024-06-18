    public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) 
    {
        var result = new List<IList<int>>();
        for(int i = 0; i < nums.Length; i++)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>(); 
            var twoSumTarget = 0 - nums[i];
            for(int j = i+1; j < nums.Length; j++)
            {
                    if(dict.ContainsKey(nums[j]))
                    {
                        List<int> twoSumResult = new List<int>{
                            nums[i], dict[nums[j]], nums[j]    
                        };
                        twoSumResult.Sort();

                        bool twoSumExists = result.Any(x => x.SequenceEqual(twoSumResult) ); 
                        
                        if(!twoSumExists)
                        {
                            result.Add(twoSumResult);
                        }
                    }
                    var twoSumRemainder = twoSumTarget -nums[j];
                    if(!dict.ContainsKey(twoSumRemainder))
                    {
                        dict.Add(twoSumRemainder, nums[j]);
                    }
                }
        }
        return result;
    }
}