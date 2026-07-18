public class Solution {
    public bool IsPalindrome(string s) {
     string snew = new(s.Where(c =>char.IsLetterOrDigit(c)).Select(c=>char.ToLower(c)).ToArray());
        char [] chars =snew.ToCharArray();
        int left=0;
        int right=chars.Length -1;
   
        while(left < right)
        {
            if(! (chars[left]== chars[right]))
            return false;

            left++;
            right--;
        }
        return true;
    }
}
