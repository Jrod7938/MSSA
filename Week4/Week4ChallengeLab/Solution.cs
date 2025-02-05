namespace Week4ChallengeLab {
    internal class Solution {
        // If number contains 3
        // Write a method that checks if given number(positive integer) contains digit 3. Do not convert number to other type.Do not use built-in functions like Contains(), StartsWith(), etc.
        // Expected input and output
        // IfNumberContains3(7201432) → true IfNumberContains3(87501) → false
        internal static void Part1() {
            int input = GetInput<int>("Enter a number to check if 3 is in it: ");
            Console.WriteLine(ContainsThree(input));
        }

        private static bool ContainsThree(int number) {
            while(number > 0) {
                if (number % 10 == 3) return true;
                number /= 10;
            }
            return false;
        }

        // Divisible by 2 or 3
        // Given two integers, write a method that returns their multiplication if they are both divisible by 2 or 3, otherwise returns their sum.
        // Expected input and output
        // DivisibleBy2Or3(15, 30) → 450 DivisibleBy2Or3(2, 90) → 180 DivisibleBy2Or3(7, 12) → 19
        internal static void Part2() {
            int num1 = GetInput<int>("Enter a number: ");
            int num2 = GetInput<int>("Enter a number: ");
            Console.WriteLine(DivisibleByTwoOrThree(num1, num2));
        }

        private static int DivisibleByTwoOrThree(int number1, int number2) {
            return (number1 % 2 == 0 || number1 % 3 == 0) && (number2 % 2 == 0 || number2 % 3 == 0) ? number1 * number2 : number1 + number2;
        }

        // Write a function that reverses a string. The input string is given as an array of characters s.
        // You must do this by modifying the input array in-place. (Problem 344 in leetcode)
        // Example 1:
        // Input: s = ["h", "e", "l", "l", "o"]
        // Output: ["o", "l", "l", "e", "h"]
        // Example 2:
        // Input: s = ["H", "a", "n", "n", "a", "h"]
        // Output: ["h", "a", "n", "n", "a", "H"]
        internal static void Part3() {
            string input = GetInput<string>("Enter a string to reverse: ");
            Console.WriteLine(ReverseString(input.ToCharArray()));
        }

        private static string ReverseString(char[] input) {
            int i = 0;
            int j = input.Length - 1;

            while(i <= j) {
                (input[i], input[j]) = (input[j], input[i]);
                i++;
                j--;
            }
            return new string(input);
        }

        private static T GetInput<T>(string prompt) {
            Console.Write(prompt);
            try {
                return (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            } catch (Exception exception) {
                Console.WriteLine($"Invalid input. Please enter input of type {typeof(T).Name}\n{exception.Message}");
                return GetInput<T>(prompt);
            }
        }
    }
}