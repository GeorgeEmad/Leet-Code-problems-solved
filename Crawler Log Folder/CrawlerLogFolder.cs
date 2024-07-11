public class Solution {
    public int MinOperations(string[] logs) 
    {
        const string remainInSamePath = "./";
        const string goBackPath = "../"; 
        int result = 0;
        for(int i = 0; i<logs.Length; i++)
        {
            if(logs[i] == goBackPath && result != 0)
            {
                result--;
            }
            else if(logs[i] != remainInSamePath && logs[i] != goBackPath)
            {
                result++;
            }

        }
        return result;
    }
}