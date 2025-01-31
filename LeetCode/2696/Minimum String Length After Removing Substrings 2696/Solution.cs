
internal static class Solution {
    public static int MinLength(string s) {
        while(s.Contains("AB") || s.Contains("CD")){
            s = s.Replace("AB","").Replace("CD","");
        }
        return s.Length;
    }
}