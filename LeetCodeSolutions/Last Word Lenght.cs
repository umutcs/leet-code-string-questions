public class Solution {
    public int LengthOfLastWord(string s) {
        s = s.Trim();
        
        int lastSpaceIndex = s.LastIndexOf(' ');
        if (lastSpaceIndex == -1) {
            return s.Length;
        } else {
            return s.Length - lastSpaceIndex - 1;
        }
    }
}
