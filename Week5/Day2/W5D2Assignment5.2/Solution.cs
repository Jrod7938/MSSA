using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5D2Assignment5._2 {
    internal class Solution {
        // Given a string s consisting of words and spaces, return the length of the last word in the string. A word is a maximal substring consisting of non-space characters only.
        // Example 1:
        // Input: s = "Hello World"
        // Output: 5
        // Explanation: The last word is "World" with length 5.
        // Example 2:
        // Input: s = " fly me to the moon "
        // Output: 4
        // Explanation: The last word is "moon" with length 4.
        internal static void Part1() {
            string input = GetInput<string>("Enter a string: ");
            Console.WriteLine(LengthOfLastWord(input));
        }

        private static int LengthOfLastWord(string input) {
            return input.Trim().Split(' ').Last().Length;
        }

        // Write a program in C# Sharp to print the first n natural number using recursion.
        // Test Data :
        // How many numbers to print : 10
        // Expected Output :
        // 1 2 3 4 5 6 7 8 9 10
        internal static void Part2() {
            int number = GetInput<int>("Enter the amount of Natural Numbers to print: ");
            FirstNNaturalNumbers(number);
            Console.WriteLine();
        }

        private static void FirstNNaturalNumbers(int number) {
            if (number == 0) return;
            FirstNNaturalNumbers(number - 1);
            Console.Write($"{number} ");
        }

        // Write a program in C# Sharp to print numbers from n to 1 using recursion.
        // Test Data :
        // How many numbers to print : 10
        // Expected Output :
        // 10 9 8 7 6 5 4 3 2 1
        internal static void Part3() {
            int number = GetInput<int>("Enter a Number to count down from: ");
            CountDownFromN(number);
            Console.WriteLine();
        }

        private static void CountDownFromN(int number) {
            if (number == 0) return;
            Console.Write($"{number} ");
            CountDownFromN(number - 1);
        }

        // Write a program in C# Sharp to check whether a given string is Palindrome or not using recursion.
        // Test Data :
        // Input a string : RADAR
        // Expected Output :
        // The string is Palindrome.
        internal static void Part4() {
            string input = GetInput<string>("Enter a word to check isPalindrome: ");
            Console.WriteLine(IsPalindrome(input) ? "The String is a Palindrome" : "The string is not a Palindrome");
        }

        private static bool IsPalindrome(string input) {
            if (input.Length <= 1) return true;
            if (input[0] != input[input.Length - 1]) return false;
            return IsPalindrome(input.Substring(1, input.Length - 2));
        }

        private static T GetInput<T>(string prompt) {
            Console.Write(prompt);
            try {
                return (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            } catch (Exception exception) {
                Console.WriteLine(exception.Message);
                return GetInput<T>(prompt);
            }
        }
    }
}
