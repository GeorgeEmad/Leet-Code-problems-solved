public class Solution {
    public IList<string> result;
    public int parenCount; 
    public IList<string> GenerateParenthesis(int n) {
        result = new List<string>();
        parenCount = n;
        backtracking("", 0, 0);
        return result;
    }

    public void backtracking(string currentResult, int opened, int closed)
    {
        if(opened == closed && opened == parenCount){
            result.Add(currentResult);
            return;
        }

        if(opened < parenCount)
        {
            backtracking(currentResult + "(", opened + 1, closed);
        }

        if(closed < opened)
        {
            backtracking(currentResult + ")", opened, closed + 1);
        }

    }
}