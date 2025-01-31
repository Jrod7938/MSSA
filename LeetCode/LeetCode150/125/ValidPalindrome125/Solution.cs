internal static class Solution {
    public static bool IsPalindrome(string s) {
        int left = 0, right = s.Length - 1;
        
        while (left < right) {
            if (!Char.IsLetterOrDigit(s[left])) {
                left++;
            } else if (!Char.IsLetterOrDigit(s[right])) {
                right--;
            } else {
                if (Char.ToLower(s[left]) != Char.ToLower(s[right])) {
                    return false;
                }
                left++;
                right--;
            }
        }
        return true;
    }
}