
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Reflection;

namespace Week5ChallengeLab {
    internal class Solution {
        // Given a non-empty array of integers nums, every element appears twice except for one.Find that single one.
        // Example 1:
        // Input: nums = [2, 2, 1]
        // Output: 1
        // Example 2:
        // Input: nums = [4, 1, 2, 1, 2]
        // Output: 4
        // Example 3:
        // Input: nums = [1]
        // Output: 1
        internal static void Part1() {
            int size = GetInput<int>("Enter size of array: ");
            int[] numbers = new int[size];
            for(int i = 0; i < numbers.Length; i++) {
                numbers[i] = GetInput<int>($"Enter number[{i}]: ");
            }

            Console.WriteLine(UniqueElement(numbers));
        }

        private static int UniqueElement(int[] numbers) {
            int sum = 0;
            foreach(int number in numbers) {
                sum ^= number;
            }
            return sum;
        }

        // Given an array nums containing n distinct numbers in the range[0, n], return the only number in the range that is missing from the array.
        // Example 1:
        // Input: nums = [3, 0, 1]
        // Output: 2
        // Explanation: n = 3 since there are 3 numbers, so all numbers are in the range [0, 3]. 2 is the missing number in the range since it does not appear in nums.
        // Example 2:
        // Input: nums = [0, 1]
        // Output: 2
        // Explanation: n = 2 since there are 2 numbers, so all numbers are in the range [0, 2]. 2 is the missing number in the range since it does not appear in nums. 
        // Example 3:
        // Input: nums = [9, 6, 4, 2, 3, 5, 7, 0, 1]
        // Output: 8
        // Explanation: n = 9 since there are 9 numbers, so all numbers are in the range [0, 9]. 8 is the missing number in the range since it does not appear in nums.
        internal static void Part2() {
            int size = GetInput<int>("Enter size of array: ");
            int[] numbers = new int[size];
            for (int i = 0; i < numbers.Length; i++) {
                numbers[i] = GetInput<int>($"Enter number[{i}]: ");
            }
            Console.WriteLine(MissingNumber(numbers));
        }

        private static int MissingNumber(int[] numbers) {
            for(int i = numbers.Min(); i < numbers.Max(); i++) {
                if (!numbers.Contains(i)) return i;
            }
            return -1;
        }

        private static T GetInput<T>(string prompt) { // helper function to get input from user
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