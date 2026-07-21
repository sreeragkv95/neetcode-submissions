public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
        Dictionary<int,int> nums=new();

        for(int i=0;i<numbers.Length;i++)
        {
            nums[numbers[i]]=i;
        }

 for(int i=0;i<numbers.Length;i++)
 {
int num2 = target - numbers[i];
if(nums.ContainsKey(num2) && nums[num2] != i)
{
    return new int [] {nums[numbers[i]]+1,nums[num2]+1};
}
 }      

 return new int [] {};  

    }
}
