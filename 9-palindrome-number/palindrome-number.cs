public class Solution {
    public bool IsPalindrome(int x)  {
        if(x<0) return false;
        int original = x;
        int result = 0;
        while(x > 0){

            var modulus = x % 10; 
            x = x / 10;
            result = result * 10 + modulus; 


        }
        return result == original ;
    }
}