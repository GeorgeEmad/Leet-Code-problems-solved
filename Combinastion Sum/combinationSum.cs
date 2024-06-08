public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) 
    {
        
        var result = new List<IList<int>>();
        Backtracking(0,0,new List<int>(),target,result,candidates);
        return result;   
    }

    public void Backtracking(int currentSum,int index, IList<int> currentList, int target, IList<IList<int>> result,  int[] candidates){
        if(currentSum > target)
        {
            return;
        }

        if(currentSum == target){
            result.Add(currentList.ToList());
            return;
        }

        for(int i = index; i < candidates.Length; i++)
        {
            
            currentList.Add(candidates[i]);
            Backtracking(currentSum + candidates[i],i,  currentList, target, result, candidates);
            currentList.RemoveAt(currentList.Count - 1);
        }

    }

}

