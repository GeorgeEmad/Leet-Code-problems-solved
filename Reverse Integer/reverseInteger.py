class Solution:
    def reverse(self, x: int) -> int:
        output = 0
        temp = abs(x)
        negflag = 0
        if x != 0:
            negflag = x/temp
        for i in range(len(str(temp))):
            digit = temp % 10
            temp = int(temp / 10)
            output *= 10
            output += digit 
        output *= negflag
        if not((output < ((2**31) - 1)) and (output > -(2**31))):
            return 0
        else:
            return int(output)
        
        
                
