/**
For two strings s and t, we say "t divides s" if and only if 
s = t + t + t + ... + t + t (i.e., t is concatenated with itself 
one or more times). Given two strings str1 and str2, return 
the largest string x such that x divides both str1 and str2.
Example 1:

Input: str1 = "ABCABC", str2 = "ABC"
Output: "ABC"

Example 2:

Input: str1 = "ABABAB", str2 = "ABAB"
Output: "AB"

Example 3:

Input: str1 = "LEET", str2 = "CODE"
Output: ""
*/

public class Solution {
    public static string GcdOfStrings(string str1, string str2) {
        if((str1 + str2) != (str2 + str1)) return ""; // if the strings are not equal, return empty string

        int gcdLength = GcdOfStrings(str1.Length, str2.Length); // get the gcd of the lengths of the strings

        return str1.Substring(0, gcdLength); // return the substring of str1 from index 0 to gcdLength
    }

    private static int GcdOfStrings(int length1, int length2){
        while(length2!=0){
            int temp = length2;
            length2 = length1 % length2;
            length1 = temp;
        }
        return length1;
    }
}