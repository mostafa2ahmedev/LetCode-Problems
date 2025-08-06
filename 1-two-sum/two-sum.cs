public class Solution
{
    public  int[] TwoSum(int[] nums, int target)//[3, 2, 4]    6 
    {
        
      Dictionary<int, int> map = new Dictionary<int, int>();
       int Complement= 0;
        for (int i = 0; i < nums.Length; i++)  
        {
            Complement = target - nums[i];
            if (map.ContainsKey(Complement)) {
                return new int[] { map[Complement], i };        
        }
           map[nums[i]]=i ;   //Key:number    value>index
        }
   return new int[] {};
    }
}