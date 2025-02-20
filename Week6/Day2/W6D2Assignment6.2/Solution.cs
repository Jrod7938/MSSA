using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W6D2Assignment6._2 {
    internal static class Solution {

        // Write a C# program to implement a stack by
        // using array with push and pop operations. 
        public static void Part1() {
            bool run = true;
            StackLL<int> stack = new StackLL<int>();
            while (run) {
                int option = GetInput<int>("What Operation: \n1. Push \n2. Pop\n3. Peek\n");
                switch (option) {
                    case 1:
                        stack.Push(GetInput<int>("Enter a number to push: "));
                        Console.WriteLine("Stack After Operation: ");
                        stack.Display();
                        break;
                    case 2:
                        Console.WriteLine(stack.Pop());
                        Console.WriteLine("Stack After Operation: ");
                        stack.Display();
                        break;
                    case 3:
                        Console.WriteLine(stack.Peek());
                        Console.WriteLine("Stack After Operation: ");
                        stack.Display();
                        break;
                    default:
                        Console.WriteLine("Invalid input, continuing program.");
                        run = false;
                        break;
                }
            }
        }

        // Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
        // The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
        // You must write an algorithm that runs in O(n) time and without using the division operation.
        // Example 1:
        // Input: nums = [1, 2, 3, 4]
        // Output: [24, 12, 8, 6]
        // Example 2:
        // Input: nums = [-1, 1, 0, -3, 3]8
        // Output: [0, 0, 9, 0, 0]
        public static void Part2() {
            int size = GetInput<int>("Enter size of array: ");
            int[] array = new int[size];
            for(int i = 0; i < array.Length; i++) {
                array[i] = GetInput<int>($"Enter number [{i}]: ");
            }
            array = ProductExceptSelf(array);
            foreach(int num in array) { Console.WriteLine(num); }
        }

        public static int[] ProductExceptSelf(int[] nums) {
            int[] answer = new int[nums.Length];

            answer[0] = 1;
            for (int i = 1; i < nums.Length; i++) { // prefix
                answer[i] = answer[i - 1] * nums[i - 1];
            }

            int suffix = 1;
            for (int i = nums.Length - 1; i >= 0; i--) { // product
                answer[i] *= suffix;
                suffix *= nums[i];
            }

            return answer;
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
