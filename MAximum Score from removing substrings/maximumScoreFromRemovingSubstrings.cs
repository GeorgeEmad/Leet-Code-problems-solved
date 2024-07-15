public class Solution {
    public int MaximumGain(string s, int x, int y) {
        int maximumBenefitScore, minimumBenefitScore;
        string maximumBenefitString, minimumBenefitString;
        if(x >= y){
            maximumBenefitScore = x;
            maximumBenefitString = "ab";
            minimumBenefitScore = y;
            minimumBenefitString = "ba";
        }
        else
        {
            maximumBenefitScore = y;
            maximumBenefitString = "ba";
            minimumBenefitScore = x;
            minimumBenefitString = "ab";
        }

        var resultScore = 0;
        while(s.IndexOf(maximumBenefitString) != -1){
            var index = s.IndexOf(maximumBenefitString);
            var input = new StringBuilder(s);
            input.Remove(index, maximumBenefitString.Length);
            resultScore += maximumBenefitScore;
            s= input.ToString();
        }

        while(s.IndexOf(minimumBenefitString) != -1){
            var index = s.IndexOf(minimumBenefitString);
            var input = new StringBuilder(s);
            input.Remove(index, minimumBenefitString.Length);
            resultScore += minimumBenefitScore;
            s= input.ToString();
        }

        return resultScore;
    }
}