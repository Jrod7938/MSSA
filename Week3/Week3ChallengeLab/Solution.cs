
namespace Week3ChallengeLab {
    internal class Solution {
        /*
        Given a string, write a method that checks if it is a palindrome 
        (is read the same backward as forward). Assume that string may 
        consist only of lower-case letters.
        Expected input and output
        IsPalindrome("eye") → true
        IsPalindrome("home") → false
         */
        internal static void Part1() {
            string input = GetInput<string>("Enter a word to check isPalindrome: ");
            Console.WriteLine(isPalindrome(input));
        }

        private static bool isPalindrome(string input) {
            int lastPointer = input.Length - 1;
            int firstPointer = 0;
            while(firstPointer <= lastPointer) {
                if (input[firstPointer] != input[lastPointer]) return false;
                firstPointer++;
                lastPointer--;
            }
            return true;
        }

        /*
        Sum digits in string
        Given a string, write a method which returns sum of all
        digits in that string. Assume that string contains only 
        single digits.
        Expected input and output
        SumDigitsInString("1q2w3e") → 6 SumDigitsInString("L0r3m.1p5um") → 9
        SumDigitsInString("") → 0
         */
        internal static void Part2() {
            string input = GetInput<string>("Enter a string of letters and numbers: ");
            Console.WriteLine(SumDigitsInString(input));
        }

        private static int SumDigitsInString(string input) {
            int sum = 0;
            for(int i = 0; i < input.Length; i++) {
                if (char.IsDigit(input[i])) sum += int.Parse(input[i].ToString());
            }
            return sum;
        }

        /*
        Given an array of integers nums and an integer target, 
        return indices of the two numbers such that they add up 
        to target.
        You may assume that each input would have exactly one 
        solution, and you may not use the same element twice.
        Input: nums = [2,7,11,15], target = 9
        Output: [0,1]
        Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
         */
        internal static void Part3() {
            int size = GetInput<int>("Enter size of array: ");
            int[] numbers = new int[size];
            for(int i = 0; i< numbers.Length; i++) {
                int number = GetInput<int>($"Enter a number for [{i}]: ");
                numbers[i] = number;
            }
            int target = GetInput<int>("Enter the target number to find: ");
            var twoSum = TwoSum(numbers, target);
            Console.WriteLine($"[{twoSum[0]}, {twoSum[1]}]");
        }

        private static int[] TwoSum(int[] numbers, int target) {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for(int i = 0; i < numbers.Length; i++) {
                map[numbers[i]] = i;
            }

            for(int i = 0; i < numbers.Length; i++) {
                int complement = target - numbers[i];
                if (map.ContainsKey(complement) && map[complement] != i) return new int[] { i , map.GetValueOrDefault(complement) };
            }
            return new int[] { };
        }

        /*
        You are given a string s consisting only of uppercase English letters.
        You can apply some operations to this string where, in one operation, 
        you can remove any occurrence of one of the substrings "AB" or "CD" from s.
        Return the minimum possible length of the resulting string that you can obtain.
        Note that the string concatenates after removing the substring and could 
        produce new "AB" or "CD" substrings.
        **Hint : Use Replace method of string.
        Example 1:
        Input: s = "ABFCACDB"
        Output: 2
        Explanation: We can do the following operations:
        - Remove the substring "ABFCACDB", so s = "FCACDB".
        - Remove the substring "FCACDB", so s = "FCAB".
        - Remove the substring "FCAB", so s = "FC".
        So the resulting length of the string is 2.
        It can be shown that it is the minimum length that we can obtain.
        Example 2:
        Input: s = "ACBBD"
        Output: 5
        Explanation: We cannot do any operations on the string so the length remains 
        the same.
         */
        internal static void Part4() {
            string input = GetInput<string>("Enter letters: ").ToUpper();
            Console.WriteLine(RemoveSubstring(input));
        }

        private static int RemoveSubstring(string input) {
            while(input.Contains("AB") || input.Contains("AB")) {
                input = input.Replace("AB", "").Replace("CD","");
            }
            return input.Length;
        }

        public static T GetInput<T>(string prompt) {
            Console.Write(prompt);
            string userInput = Console.ReadLine();
            try {
                var input = Convert.ChangeType(userInput, typeof(T));
                return (T)input;
            } catch (Exception exception) {
                Console.WriteLine($"Please enter input of type {typeof(T).Name}.\nError Message: {exception.Message}");
                return GetInput<T>(prompt);
            }
                
        }
    }
}