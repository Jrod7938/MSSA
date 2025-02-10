namespace W5D1Assignment5._1 {
    internal class Solution {
        // Given an integer x, return true if x is a palindrome, and false otherwise.
        // Example 1:
        // Input: x = 121
        // Output: true
        // Explanation: 121 reads as 121 from left to right and from right to left.
        // Example 2:
        // Input: x = -121
        // Output: false
        // Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
        internal static void Part1() {
            int number = GetInput<int>("Enter a number to check isPalindrome: ");
            Console.WriteLine(IsNumberPalindrome(number));
        }

        private static bool IsNumberPalindrome(int number) {
            if (number < 0) return false;
            int original = number;
            int reversed = 0;
            while(number > 0) {
                int digit = number % 10;
                reversed = reversed * 10 + digit;
                number /= 10;
            }
            return original == reversed;
        }

        // Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
        // Test Data :
        // Enter a number: 1234
        // Expected Output :
        // The sum of the digits of the number 1234 is : 10
        internal static void Part2() {
            int number = GetInput<int>("Enter a number find sum of digits: ");
            Console.WriteLine(SumOfDigits(number));
        }

        private static int SumOfDigits(int number) {
            int sum = 0;
            while(number > 0) {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        // Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
        // Example 1:
        // Input: nums = [1, 2, 3, 1]
        // Output: true
        // Example 2:
        // Input: nums = [1, 2, 3, 4]
        // Output: false
        // Example 3:
        // Input: nums = [1, 1, 1, 3, 3, 4, 3, 2, 4, 2]
        // Output: true
        internal static void Part3() {
            int size = GetInput<int>("Enter size of array: ");
            int[] array = new int[size];
            for(int i = 0; i < array.Length; i++) {
                array[i] = GetInput<int>($"Enter number for array[{i}]: ");
            }
            Console.WriteLine(RepeatingNumbers(array));
        }

        private static bool RepeatingNumbers(int[] array) {
            HashSet<int> seen = new HashSet<int>();
            foreach(int number in array) {
                if (!seen.Add(number)) return true;
            }
            return false;
        }

        private static T GetInput<T>(string prompt) {
            Console.Write(prompt);
            try {
                return (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            }catch(Exception exception) {
                Console.WriteLine($"Invalid input. Please enter input of type: {typeof(T).Name}\n{exception.Message}");
                return GetInput<T>(prompt);
            }
        }
    }
}