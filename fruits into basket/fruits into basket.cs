public class Solution {
    public int TotalFruit(int[] fruits) {
        int maxTotal = 0;
        int basket1Type =  fruits[0]; 
        int basket2Type = -1;
        int currentTotal = 0;
        int indexBask2 = 0;
        for(int i=0; i< fruits.Length; i++)
        {

            if(fruits[i] != basket1Type && basket2Type == -1){
                basket2Type = fruits[i];
                indexBask2 = i;
            }
            
            bool added = false;
            if(fruits[i] == basket1Type || fruits[i] == basket2Type){
                currentTotal++;
                added = true;
            }
            if(currentTotal > maxTotal)
            {
                maxTotal = currentTotal;
            }

            if(!added){
                basket2Type = -1;
                basket1Type = fruits[indexBask2];
                currentTotal = 1;
                i = indexBask2 ;
            }

        }
        return maxTotal;
    }
}