class Solution:
    def isPalindrome(self, x: int) -> bool:
        if x < 0:
            return False
        else:
            temp = x
            Reverse = 0    
            while(x > 0):    
                dig = x %10    
                Reverse = (Reverse *10) + dig    
                x = x//10
            if temp == Reverse:
                return True
            else:
                return False
     
        
        
        
        
        
        
        
        
        
        
        

