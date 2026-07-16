public class Solution {
    public int[] TwoSum(int[] nums, int target) {

Dictionary <int,int> sample=new();

for(int j=0;j<nums.Length;j++)
{
    sample[nums[j]]=j;
}

for(int i=0;i<nums.Length;i++)
{
    int complement=target-nums[i];
    
    if(sample.ContainsKey(complement) && sample[complement] != i)
    return new [] {
       i, sample[complement]
    };
}

return Array.Empty<int>();

    }
}
