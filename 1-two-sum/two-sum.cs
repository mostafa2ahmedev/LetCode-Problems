public class Solution
{
    public  int[] TwoSum(int[] nums, int target)//[3, 2, 4]    6 
    {
        
      
        for (int i = 0; i < nums.Length - 1; i++)  
        {

            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                    return new int[] { i, j };


            }

        }
        return  new int[0];
    }
}