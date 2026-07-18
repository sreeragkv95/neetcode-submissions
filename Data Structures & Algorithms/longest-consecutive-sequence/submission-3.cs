public class Solution {
    public int LongestConsecutive(int[] nums) {
        
        if(nums.Length ==0)
        return 0;
        if(nums.Length ==1)
        return 1;
HashSet<int> sample=new(nums);

int maxlength=1;

foreach(int num in nums)
{
  if(!sample.Contains(num - 1))
  {
   int currentlength=1;
   int temp=num + 1;
  while(sample.Contains(temp))
  {
    currentlength++;
    temp++;


  }
  maxlength=Math.Max(maxlength,currentlength);
  }
        }
          return maxlength;
    }
}
