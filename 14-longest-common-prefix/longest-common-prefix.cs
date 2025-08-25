public class Solution
{
    public  string LongestCommonPrefix(string[] strs)
    {

        string minmumString = strs[0];

        for (int i = 0; i < strs.Length; i++)
        {
            if (strs[i].Length < minmumString.Length)
                minmumString = strs[i];
        }
        string result = string.Empty;
   
        for (int i = 0; i < strs.Length; i++)
        {
            string word = strs[i]; //flower
        
            for (int j = 0; j < minmumString.Length; j++)
            {
                if (word[j] != minmumString[j])
                    break;
                else {
                    result += minmumString[j]; //fl
                }
            


            }
            minmumString = result;
            result = string.Empty;
        }
        return minmumString;
    }
}