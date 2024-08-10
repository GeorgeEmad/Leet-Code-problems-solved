public class Solution {
    IList<IList<int>> result;
    public int target; 
    public int[] candidates;
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        result = new List<IList<int>>();
        this.target = target;
        this.candidates = candidates;
        List<int> currenCandidate = new List<int>();
        backtracking(0, currenCandidate, -1);
        return result;
    }

    public void backtracking(int currentSum, List<int> currenCandidate, int currIndex)
    {
 
        if(currentSum == target){
            List<int> temp = currenCandidate.ToList();
            temp.Sort();
            if(!isDuplicate(result, temp))
            {
                result.Add(temp);
            }
            return;
        }

        for(int i = currIndex+1 ; i < candidates.Length; i++)
        {
            currenCandidate.Add(candidates[i]);
            if(currentSum + candidates[i] <= target)
            {
                backtracking(currentSum + candidates[i], currenCandidate, i);
            }
            currenCandidate.RemoveAt(currenCandidate.Count - 1);

        }
    }

    public bool isDuplicate(IList<IList<int>> result, IList<int> currentRes)
    {
        for (int i = 0; i < result.Count; i++) 
        {
            IList<int> resultExistingCandidate = result[i]; 
            if(resultExistingCandidate.Count != currentRes.Count)
            {
                continue;
            }
            
            var isDuplicate = true;
            for(int j= 0;  j < currentRes.Count;j++){
                if(resultExistingCandidate[j] != currentRes[j])
                    isDuplicate = false;
            }
            if(isDuplicate)
            {
                return true;
            }
            
        }
        return false;
    }

    
}

