public class Solution {
    public bool IsPalindrome(string s) {
        s = new string(s.Where(char.IsLetterOrDigit).Select(char.ToLower).ToArray());

        string reversed = new string(s.Reverse().ToArray());

        return s == reversed;
    }
}
