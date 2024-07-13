
public class Solution {
    public string ReverseParentheses(string s) {
        Stack<StringBuilder> resultStack = new Stack<StringBuilder>();  
        var result = new StringBuilder();
        foreach(char character in s){
            if(character == '(')
            {
                resultStack.Push(new StringBuilder());
            }
            else if(character == ')')
            {
                var poppedBuilder = resultStack.Pop();
                Reverse(poppedBuilder);
                if(resultStack.Count == 0){
                    result.Append(poppedBuilder);
                }
                else{
                    var currentBuilder = resultStack.Peek();
                    currentBuilder.Append(poppedBuilder);
                }
            }
            else if(resultStack.Count == 0 )
            {
                result.Append(character);
            }
            else if(resultStack.Count > 0)
            {
                var currentBuilder = resultStack.Peek();
                currentBuilder.Append(character);
            }
        }
        return result.ToString();
    }

    public void Reverse(StringBuilder sb)
    {
        var length = sb.Length;
        for(int i = 0; i < length / 2 ; i++)
        {
            var temp = sb[i];
            sb[i] = sb[length - 1 - i];
            sb[length - 1 - i] = temp; 
        }
    }
}